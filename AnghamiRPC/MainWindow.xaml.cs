using System;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;
using AnghamiRPC.Properties;

namespace AnghamiRPC
{
    public partial class MainWindow : Window
    {
        private Thread? rpcThread;
        private string? anghamiPath;
        private bool isDragging = false;
        private Point startPoint;
        private string? clientId;
        public MainWindow()
        {
            InitializeComponent();

            MouseLeftButtonDown += DragWindow;
            MouseMove += Window_MouseMove;
            MouseLeftButtonUp += Window_MouseUp;

            // Load settings on window initialization
            clientId = Properties.Settings.Default.ClientId;
            ClientIdTextBox.Text = Properties.Settings.Default.ClientId;
            anghamiPath = Properties.Settings.Default.AnghamiPath;
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                isDragging = true;
                startPoint = e.GetPosition(this);
            }
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // Stop the script before closing the window
            Program.StopScript();
            Close();
        }
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && e.LeftButton == MouseButtonState.Pressed)
            {
                Point currentPosition = e.GetPosition(this);
                this.Left = currentPosition.X - startPoint.X + this.Left;
                this.Top = currentPosition.Y - startPoint.Y + this.Top;
            }
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                isDragging = false;
            }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the client ID from the text box
            clientId = ClientIdTextBox.Text.Trim();

            // Validate the client ID
            if (IsValidDiscordClientId(clientId))
            {
                // Check if the Anghami path is present
                if (string.IsNullOrWhiteSpace(anghamiPath))
                {
                    // Display an error message and prompt the user to select the Anghami path
                    MessageBox.Show("Anghami path is not selected. Please click the Browse button and select the Anghami executable.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Save the client ID to settings
                Properties.Settings.Default.ClientId = clientId;

                // Save the Anghami path to settings
                Properties.Settings.Default.AnghamiPath = anghamiPath;

                // Save the settings
                Properties.Settings.Default.Save();

                // Now you can use clientId and anghamiPath in your thread or wherever you need them
                rpcThread = new Thread(() => Program.Start(clientId, UpdateUI, anghamiPath));
                rpcThread.Start();
            }
            else
            {
                // Display an error message if the client ID is not valid
                MessageBox.Show("Invalid Discord client ID. Please enter a valid 18-digit numerical ID.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private bool IsValidDiscordClientId(string clientId)
        {
            // Check if the client ID is 18 characters long and consists of only numerical digits
            return clientId.Length == 18 && long.TryParse(clientId, out _);
        }



        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Anghami Executable|Anghami.exe|All Files|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                anghamiPath = openFileDialog.FileName;
            }
        }
        private void UpdateUI(string message)
        {
            Dispatcher.Invoke(() =>
            {
                ConsoleLogTextBox.Text += $"{message}\n";
            });
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
           
        }
    }
}
