using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Threading;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Net.Http;
using System.Configuration;
using DiscordRpcDemo;

namespace AnghamiRPC
{

    public partial class Form1 : Form
    {

        static string GetWindowTitle(Process process)
        {
            // Ensure the process has a main window handle
            if (process.MainWindowHandle != IntPtr.Zero)
            {
                const int nChars = 256;
                StringBuilder title = new StringBuilder(nChars);
                GetWindowText(process.MainWindowHandle, title, nChars);
                return title.ToString();
            }
            return "No Main Window Title";
        }

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeDiscordPresence()
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize(tbClient.Text, ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize(tbClient.Text, ref this.handlers, true, null);
            this.presence.instance = true;
            this.presence.details = "Playing " + lbSong.Text;
            this.presence.state = "by " + lbArtist.Text + " on Anghami";
            this.presence.largeImageKey = pbSong.ImageLocation;
            this.presence.largeImageText = lbSong.Text;
            this.presence.smallImageKey = artistImageLink;
            this.presence.smallImageText = lbArtist.Text;

            DiscordRpc.UpdatePresence(ref this.presence);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists(Application.StartupPath + "\\remember.txt"))
            {

                string rememberData = File.ReadAllText(Application.StartupPath + "\\remember.txt");

                tbClient.Text = rememberData;
                

            }

        }

        string rpcName;

        private async Task<string> GetDeezerApiDataAsync(string songName)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string apiUrl = $"https://api.deezer.com/search?q={Uri.EscapeDataString(songName)}";

                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "API Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

        public string artistImageLink = string.Empty;

        bool enabled = false;

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            if (lbSong.Text != "No Current Song" && tbClient.Text != string.Empty)
            {

                enabled = true;

                if (cbRemember.Checked == true)
                {

                    File.WriteAllText(Application.StartupPath + "\\remember.txt", tbClient.Text);

                }

            }
            else if (tbClient.Text == string.Empty)
            {

                guna2MessageDialog1.Show();

            }

            Process[] processes = Process.GetProcessesByName("Anghami");

            if (processes.Length > 0)
            {
                
            }
            else
                guna2MessageDialog2.Show();

        }

        private async void CheckSong_Tick(object sender, EventArgs e)
        {
            try
            {
                CheckSong.Stop();

                Process[] processes = Process.GetProcessesByName("Anghami");

                if (processes.Length > 0)
                {
                    foreach (Process process in processes)
                    {
                        Console.WriteLine($"Process Name: {process.ProcessName}");
                        Console.WriteLine($"Window Title: {GetWindowTitle(process)}");
                        Console.WriteLine();

                        if (GetWindowTitle(process) != "No Main Window Title" && GetWindowTitle(process).Contains("▶"))
                        {
                            rpcName = GetWindowTitle(process);

                            string apiData = await GetDeezerApiDataAsync(rpcName);

                            if (!string.IsNullOrEmpty(apiData))
                            {
                                JObject parsedData = JObject.Parse(apiData);

                                // Check if "data" array exists and contains elements
                                if (parsedData["data"] != null && parsedData["data"].Any())
                                {
                                    string songName = (string)parsedData["data"][0]["title"];
                                    string artistName = (string)parsedData["data"][0]["artist"]["name"];
                                    string imageLink = (string)parsedData["data"][0]["album"]["cover_medium"];
                                    artistImageLink = (string)parsedData["data"][0]["artist"]["picture_medium"];

                                    lbSong.Text = songName;
                                    lbArtist.Text = artistName;
                                    pbSong.ImageLocation = imageLink;

                                    lbSong.Left = (pnSong.ClientSize.Width - lbSong.Size.Width) / 2;
                                    lbArtist.Left = (pnSong.ClientSize.Width - lbArtist.Size.Width) / 2;

                                    txtError.Visible = false;

                                    if (enabled)
                                    {
                                        InitializeDiscordPresence();
                                    }
                                }
                                else
                                {
                                    // Song data not found, display default values
                                    lbSong.Text = rpcName; // Display the name of the song
                                    lbArtist.Text = "Unknown Artist"; // Or any default value
                                    pbSong.Image = Properties.Resources.anghami; // Set default image
                                    txtError.Visible = true;

                                    // Update Discord RPC with default information
                                    if (enabled)
                                    {
                                        UpdateDiscordPresenceDefault();
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"No process found with the name 'Anghami'.");
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                CheckSong.Start();
            }
        }

        private void HandleInvalidData()
        {
            // Handle case where data from API is invalid or incomplete
            txtError.Visible = true;
        }

        private void HandleException(Exception ex)
        {
            // Handle any exceptions that occur during processing
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {

        }
        private void UpdateDiscordPresenceDefault()
        {
            this.presence.instance = true;
            this.presence.details = "Playing " + lbSong.Text;
            this.presence.state = "by " + lbArtist.Text + " on Anghami";
            this.presence.largeImageKey = "anghami"; // Use default image key
            this.presence.largeImageText = lbSong.Text;
            this.presence.smallImageKey = ""; // Clear small image key
            this.presence.smallImageText = ""; // Clear small image text

            DiscordRpc.UpdatePresence(ref this.presence);
        }

    }

}
