using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using SourceChord.FluentWPF;

namespace Chat
{
    public partial class ChatWindow : AcrylicWindow
    {
        private readonly ChatManager _chatManager;
        private readonly User _user;
        
        public ChatWindow(ChatManager chatManager, User user)
        {
            InitializeComponent();
            _chatManager = chatManager;
            _user = user;
            _user.OnReceived += MessageReceived;
            _chatManager.OnUserNumberChanged += UserNumberChanged;
            Title = _user.Username;
        }

        private void UserNumberChanged(int number) => TextBlockUsersNum.Text = number + " active users";

        private void VisualizeNewMessage(string message, string initiator)
        {
            if (initiator != null && initiator != _user.Username)
            {
                ListBoxMessages.Items.Add(new ListBoxItem
                {
                    Content = new TextBlock
                    {
                        TextWrapping = TextWrapping.Wrap,
                        Text = initiator + " says:",
                        TextAlignment = TextAlignment.Right
                    },
                    Background = new SolidColorBrush(Colors.LightSteelBlue),
                    HorizontalContentAlignment = HorizontalAlignment.Stretch
                });
            }

            ListBoxMessages.Items.Add(new ListBoxItem
            {
                Content = new TextBlock
                {
                    TextWrapping = TextWrapping.Wrap,
                    Text = message,
                    TextAlignment = initiator != null ? TextAlignment.Right : TextAlignment.Left
                },
                HorizontalContentAlignment = HorizontalAlignment.Stretch
            });

            ListBoxMessages.SelectedIndex = ListBoxMessages.Items.Count - 1;
            ListBoxMessages.ScrollIntoView(ListBoxMessages.SelectedItem);
        }

        private void MessageReceived(Message message) => VisualizeNewMessage(message.Data, message.Initiator.Username);

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) => e.Cancel = true;

        private void buttonSend_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxMessage.Text)) return;
            _user.Send(TextBoxMessage.Text);

            VisualizeNewMessage(TextBoxMessage.Text, null);
            TextBoxMessage.Clear();
        }

        private void buttonJoin_Click(object sender, RoutedEventArgs e)
        {
            _chatManager.OnOnLog($"{_user.Username} joined to chat");
            _chatManager.OnOnUserNumberChanged(_chatManager.GetActiveUsers()+1);
            _chatManager.AddUser(_user);
            
            ButtonJoin.IsEnabled = false;
            ButtonLeave.IsEnabled = true;
        }

        private void buttonLeave_Click(object sender, RoutedEventArgs e)
        {
            _chatManager.OnOnLog($"{_user.Username} left chat");
            _chatManager.OnOnUserNumberChanged(_chatManager.GetActiveUsers()-1);
            _chatManager.RemoveUser(_user);
            
            ButtonJoin.IsEnabled = true;
            ButtonLeave.IsEnabled = false;
        }
    }
}
