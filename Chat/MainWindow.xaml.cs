using System;
using System.Windows;
using SourceChord.FluentWPF;

namespace Chat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : AcrylicWindow
    {
        ChatManager _chatManager;
        readonly string[] _userNames = { "Nikita", "Julia", "Vladyslav" };


        const int ChatWindowWidth = 300;
        const int ChatWindowHeight = 400;
        const int MainWindowHeight = 200;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _chatManager = new ChatManager();

            _chatManager.OnLog += status =>
            {
                ListBoxLog.Items.Add($"{DateTime.Now.Date:MM/dd/yyyy H:mm:ss} {status}");
            };

            PlaceChildWindows();
        }

        private void PlaceChildWindows()
        {
            var left = (System.Windows.SystemParameters.PrimaryScreenWidth - ChatWindowWidth * _userNames.Length) / 2;
            var top = (System.Windows.SystemParameters.PrimaryScreenHeight - ChatWindowHeight - MainWindowHeight) / 2;
            for (int i = 0; i < _userNames.Length; i++)
            {
                var user = new User(_userNames[i]);
                var userWindow = new ChatWindow(_chatManager, user)
                {
                    Left = left + i * ChatWindowWidth, Width = ChatWindowWidth, Height = ChatWindowHeight, Top = top
                };
                userWindow.Show();
            }
            this.Top = top + ChatWindowHeight;
            this.Left = left;
            this.Width = _userNames.Length * ChatWindowWidth;
            this.Height = MainWindowHeight;
        }

        private void Window_Closed(object sender, EventArgs e) => Application.Current.Shutdown();
    }
}
