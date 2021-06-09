using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Lab16
{
    public partial class MainWindow : Window
    {
        private const int Amount = 16;
        private static int[] _numbers = new int[Amount];
        private static Button[] _buttons = new Button[Amount];
        private static int _lastButton;
        private readonly Label _congrats = new Label();
        private readonly Canvas c = new Canvas();


        public MainWindow()
        {
            InitializeComponent();


            SetButtons();
            _congrats.Content = "Good job!";
            _congrats.Margin = new Thickness(210, 90, 0, 0);
            _congrats.Visibility = Visibility.Hidden;
            c.Children.Add(_congrats);

            InitButtons();
        }

        private static void SetButtons()
        {
            for (var i = 0; i < _numbers.Length; i++)
            {
                int temp;
                do
                {
                    temp = new Random().Next(1, 17);

                    if (!_numbers.Contains(temp))
                    {
                        _numbers[i] = temp;
                        break;
                    }
                } while (_numbers.Contains(temp));
            }
        }

        private void ResetButtons()
        {
            c.Children.Clear();
            _lastButton = 0;
            _numbers = new int[Amount];
            SetButtons();
            _buttons = new Button[Amount];
            InitButtons();
            c.Children.Add(_congrats);
        }

        private void RandomizeButtons()
        {
            for (var i = 0; i < _buttons.Length; i++)
            for (var j = 0; j < 4; j++)
            {
                var x = _buttons[i].Margin.Left;
                var y = _buttons[i].Margin.Top;

                _buttons[i].Margin = new Thickness(_buttons[j].Margin.Left, _buttons[j].Margin.Top, 0, 0);
                _buttons[j].Margin = new Thickness(x, y, 0, 0);
            }
        }

        private void InitButtons()
        {
            for (int i = 0, j = 0, k = 0; i < _buttons.Length; i++, j++)
            {
                if (j == 4)
                {
                    j = 0;
                    k++;
                }

                _buttons[i] = new Button();
                _buttons[i].Content = _numbers[i].ToString();
                _buttons[i].Width = 45;
                _buttons[i].Height = 45;
                _buttons[i].Margin = new Thickness(k * 45 + 5, j * 45 + 5, 0, 0);

                _buttons[i].Click += (s, e) =>
                {
                    _congrats.Visibility = Visibility.Hidden;
                    RandomizeButtons();

                    var temp = s as Button;
                    int num = short.Parse(temp.Content.ToString());

                    temp.Visibility = Visibility.Hidden;

                    if (_lastButton != num - 1)
                    {
                        ResetButtons();
                    }
                    else if (num == 16)
                    {
                        ResetButtons();
                        _congrats.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        _lastButton = num;
                    }
                };
                c.Children.Add(_buttons[i]);
            }

            TabPage2.Content = c;
        }

        private void addValue_click(object sender, RoutedEventArgs e)
        {
            if (TextBoxTask1.Text != "")
            {
                ComboBox.Items.Add(TextBoxTask1.Text);
                TextBoxTask1.Clear();
            }
        }

        private void deleteValue_click(object sender, RoutedEventArgs e)
        {
            if (TextBoxTask1.Text != "") ComboBox.Items.Remove(TextBoxTask1.Text);
        }
    }
}