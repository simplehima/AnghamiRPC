using System;
using System.Threading;
using System.Windows;

namespace AnghamiRPC
{
    public partial class MainWindow : Window
    {
        private Thread? rpcThread;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            string clientId = ClientIdTextBox.Text;
            rpcThread = new Thread(() => Program.Start(clientId, UpdateUI));
            rpcThread.Start();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            Program.Stop();
        }

        private void UpdateUI(string message)
        {
            // Use this method to update UI elements from the background thread
            Dispatcher.Invoke(() =>
            {
                ConsoleLogTextBox.Text += $"{message}\n";
            });
        }

        // Ensure to stop the background thread when the application is closing
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            Program.Stop();
        }


    }
}
