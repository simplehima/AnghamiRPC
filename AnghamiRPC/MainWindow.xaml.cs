using System;
using System.IO;
using System.Threading;
using System.Windows;
using Microsoft.Win32;

namespace AnghamiRPC
{
    public partial class MainWindow : Window
    {
        private Thread? rpcThread;
        private string? anghamiPath;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            string clientId = ClientIdTextBox.Text;
            rpcThread = new Thread(() => Program.Start(clientId, UpdateUI, anghamiPath));
            rpcThread.Start();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            Program.Stop();
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
            Program.Stop();
        }
    }
}
