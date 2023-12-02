using DiscordRPC;
using DiscordRPC.Logging;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace AnghamiRPC
{
    internal class Program
    {
        private static Action<string>? updateUI;
        #region Long Back-end

        [Flags]
        internal enum SendMessageTimeoutFlags : uint
        {
            SMTO_NORMAL = 0x0,
            SMTO_BLOCK = 0x1,
            SMTO_ABORTIFHUNG = 0x2,
            SMTO_NOTIMEOUTIFNOTHUNG = 0x8,
            SMTO_ERRORONEXIT = 0x20
        }

        // Specific import for WM_GETTEXTLENGTH
        [DllImport("user32.dll", EntryPoint = "SendMessageTimeout", CharSet = CharSet.Auto)]
        internal static extern int SendMessageTimeout(
            IntPtr hwnd,
            uint Msg,              // Use WM_GETTEXTLENGTH
            int wParam,
            int lParam,
            SendMessageTimeoutFlags flags,
            uint uTimeout,
            out int lpdwResult);

        // Specific import for WM_GETTEXT
        [DllImport("user32.dll", EntryPoint = "SendMessageTimeout", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern uint SendMessageTimeoutText(
            IntPtr hWnd,
            uint Msg,              // Use WM_GETTEXT
            int countOfChars,
            StringBuilder text,
            SendMessageTimeoutFlags flags,
            uint uTImeoutj,
            out IntPtr result);

        [DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool EnumChildWindows(IntPtr window, EnumWindowProc callback, IntPtr i);

        // callback to enumerate child windows
        private delegate bool EnumWindowProc(IntPtr hwnd, IntPtr parameter);

        private static bool EnumChildWindowsCallback(IntPtr handle, IntPtr pointer)
        {
            // this method will be called foreach child window
            // create a GCHandle from pointer
            var gcHandle = GCHandle.FromIntPtr(pointer);

            // cast pointer as list
            var list = gcHandle.Target as List<IntPtr>;

            if (list == null)
                throw new InvalidCastException("Invalid cast of GCHandle as List<IntPtr>");
            updateUI?.Invoke("Invalid cast of GCHandle as List<IntPtr>");

            // Adds the handle to the list.
            list.Add(handle);

            return true;
        }

        private static IEnumerable<IntPtr> GetChildWindows(IntPtr parent)
        {
            // Create list to store child window handles.
            var result = new List<IntPtr>();

            // Allocate list handle to pass to EnumChildWindows.
            var listHandle = GCHandle.Alloc(result);

            try
            {
                // enumerates though the children
                EnumChildWindows(parent, EnumChildWindowsCallback, GCHandle.ToIntPtr(listHandle));
            }
            finally
            {
                // free unmanaged list handle
                if (listHandle.IsAllocated)
                    listHandle.Free();
            }

            return result;
        }

        internal static string GetText(IntPtr hwnd)
        {
            const uint WM_GETTEXTLENGTH = 0x000E;
            const uint WM_GETTEXT = 0x000D;
            const int DISCORD_RPC_LIMIT = 128;
            int length;
            IntPtr p;

            var result = SendMessageTimeout(hwnd, WM_GETTEXTLENGTH, 0, 0, SendMessageTimeoutFlags.SMTO_ABORTIFHUNG, 5, out length);

            if (result != 1 || length <= 0)
            {
                //Console.WriteLine("Couldn't read song name from window, returning an empty string.");
                updateUI?.Invoke("Couldn't read song name from window, returning an empty string.");
                return string.Empty;
            }

            if (length > DISCORD_RPC_LIMIT)
            {
                length = DISCORD_RPC_LIMIT;
            }

            var sb = new StringBuilder(length + 1);

            return SendMessageTimeoutText(hwnd, WM_GETTEXT, sb.Capacity, sb, SendMessageTimeoutFlags.SMTO_ABORTIFHUNG, 5, out p) != 0 ?
                    sb.ToString() :
                    string.Empty;
        }


        private static void SetStartup()
        {
            if (OperatingSystem.IsWindows())
            {
                RegistryKey? rkApp = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                rkApp?.SetValue("AnghRPC", Assembly.GetExecutingAssembly().Location);
            }
            else
            {
                //Console.WriteLine("Sorry but only Windows OS is Supported ...");
                updateUI?.Invoke("Sorry but only Windows OS is Supported ...");
            }

        }

        #endregion
        private static bool stopScript = false;

        public static DiscordRpcClient? client;

        public static void Start(string clientId, Action<string> updateUI, string anghamiPath)
        {
            while (!stopScript)
            {
                try
                {
                    // Check if the client is null or disposed
                    if (client == null || client.IsDisposed)
                    {
                        // Create a new instance of DiscordRpcClient
                        client = new DiscordRpcClient(clientId);

                        // Notify UI about the update
                        updateUI?.Invoke("Anghami RPC is now running.");
                    updateUI?.Invoke("Built By @simplehima.");
                    updateUI?.Invoke("Version 3.1.0");
                    //Set the logger
                    //client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
                    //Console.ForegroundColor = ConsoleColor.Magenta;
                    //Console.Write("Anghami RPC ");
                    //Console.ForegroundColor = ConsoleColor.Gray;
                    //Console.WriteLine("is now running.");
                    //Console.ForegroundColor = ConsoleColor.Blue;
                    //Console.WriteLine("Modded By @simplehima");
                    //Console.ForegroundColor = ConsoleColor.Green;
                    //Console.WriteLine("Version 2.3.0");

                    client.Initialize();
                    }
                    string storedRpcName = string.Empty;
                    string rpcName;
                    // add a 5-second delay to the loop
                    System.Threading.Thread.Sleep(5000);
                    while (!stopScript)
                    {
                        // add a 1-second delay to the loop
                        System.Threading.Thread.Sleep(1000);
                        Process[] processes = Process.GetProcessesByName("Anghami");
                        if (processes.Length == 0)
                        {
                            // Anghami is not running, start it
                            Process.Start(anghamiPath);
                            updateUI?.Invoke("Anghami is not running, Will Auto Start now!");
                            continue;
                        }
                        Process p = processes[0];
                        if (p.HasExited)
                        {
                            // Anghami was running but has now exited, restart it
                            Process.Start(anghamiPath);
                            updateUI?.Invoke("Anghami was running but has now exited, restarting it");
                            continue;
                        }
                        // Check if the stopScript flag is set
                        if (stopScript)
                        {
                            return;
                        }
                        rpcName = GetText(p.MainWindowHandle);

                        if (rpcName != storedRpcName)
                        {

                            storedRpcName = GetText(p.MainWindowHandle);
                            rpcName = GetText(p.MainWindowHandle);

                            int pFrom = rpcName.IndexOf("") + "".Length;
                            int pTo = rpcName.LastIndexOf(" - ");

                            String displaysongname = rpcName.Substring(pFrom, pTo - pFrom);
                            String displayartist = rpcName.Substring(rpcName.LastIndexOf('-') + 1);

                            client.SetPresence(new RichPresence()
                            {
                                Details = displaysongname,
                                State = "by" + displayartist,
                                Assets = new Assets()
                                {
                                    LargeImageKey = "anghami",
                                    LargeImageText = $"Playing {rpcName}.",
                                    SmallImageKey = "play",
                                },
                                Timestamps = Timestamps.Now
                            });
                        }



                        Thread.Sleep(500);


                    }
                }
                catch (Exception ex)
                {

                    // Notify UI about errors
                    updateUI?.Invoke($"Error: {ex.Message}");

                    //Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine(ex.Message);
                    //Console.ResetColor();
                }


            }

        }

        // Add a method to stop the script
        public static void StopScript()
        {
            stopScript = true;
        }

    }
}
