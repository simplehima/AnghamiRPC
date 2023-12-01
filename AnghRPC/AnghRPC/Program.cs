using DiscordRPC;
using DiscordRPC.Logging;
using Microsoft.Win32;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace AnghRPC
{
    internal class Program
    {

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
            int length;
            IntPtr p;

            var result = SendMessageTimeout(hwnd, WM_GETTEXTLENGTH, 0, 0, SendMessageTimeoutFlags.SMTO_ABORTIFHUNG, 5, out length);

            if (result != 1 || length <= 0)
                return string.Empty;

            var sb = new StringBuilder(length + 1);

            return SendMessageTimeoutText(hwnd, WM_GETTEXT, sb.Capacity, sb, SendMessageTimeoutFlags.SMTO_ABORTIFHUNG, 5, out p) != 0 ?
                    sb.ToString() :
                    string.Empty;
        }


        private static void SetStartup()
        {
            RegistryKey rkApp = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rkApp.SetValue("AnghRPC", Assembly.GetExecutingAssembly().Location);

        }

        #endregion

        public static DiscordRpcClient client;

        static void Main(string[] args)
        {

            try
            {

                client = new DiscordRpcClient("1059437128938954873");

                //Set the logger
                client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

                try
                {

                    var p = Process.GetProcessesByName("Anghami").First();

                    string storedRpcName = string.Empty;

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Anghami RPC ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("is now running.");


                    client.Initialize();

                    // SetStartup();

                    string rpcName;

                    while (true)
                    {

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

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Can't find Anghami, or an issue may have occured. ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Please click any key to close this application." + Environment.NewLine);

                    Console.WriteLine(ex);

                    return;

                }

            }
            catch
            {

                var applicationPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                Process.Start(applicationPath);
                Environment.Exit(Environment.ExitCode);

            }

        }
    }
}
