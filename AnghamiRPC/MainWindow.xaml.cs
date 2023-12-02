using System;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;

namespace AnghamiRPC
{
    public partial class MainWindow : Window
    {
        private Thread? rpcThread;
        private string? anghamiPath;
        private bool isDragging = false;
        private Point startPoint;

        public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();
            MouseLeftButtonDown += DragWindow;
            MouseMove += Window_MouseMove;
            MouseLeftButtonUp += Window_MouseUp;
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
