using System;
using System.Globalization;
using System.Windows;

namespace Lab.Calc
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    internal enum EquationPart
    {
        Left,
        Right
    }

    public partial class MainWindow
    {
        private string _numberA;
        private string _numberB;
        private char? _operator;
        private EquationPart currentPart = EquationPart.Left;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AbsButton_OnClick(object sender, RoutedEventArgs e)
        {
        }

        private void ClearButton_OnClick(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "";
            _numberA = null;
            _numberB = null;
            _operator = null;
            currentPart = EquationPart.Left;
        }

        private void Button0_OnClick(object sender, RoutedEventArgs e)
        {
            if (currentPart == EquationPart.Left)
            {
                if (_numberA != null && (_numberA != null || _numberA.Contains(",")))
                    TextBox.Text += "0";
                else
                    TextBox.Text = "0";
                _numberA += "0";
            }
            else if (currentPart == EquationPart.Right)
            {
                if (_numberB != null && (_numberB != null || _numberB.Contains(",")))
                    TextBox.Text += "0";
                else
                    TextBox.Text = "0";
                _numberB += "0";
            }
        }

        private void Button1_OnClick(object sender, RoutedEventArgs e)
        {
            if (currentPart == EquationPart.Left)
            {
                if (_numberA != null && (_numberA != null || _numberA.Contains(",")))
                    TextBox.Text += "1";
                else
                    TextBox.Text = "1";
                _numberA += "1";
            }
            else if (currentPart == EquationPart.Right)
            {
                if (_numberB != null && (_numberB != null || _numberB.Contains(",")))
                    TextBox.Text += "1";
                else
                    TextBox.Text = "1";
                _numberB += "1";
            }
        }

        private void Button2_OnClick(object sender, RoutedEventArgs e)
        {
            if (currentPart == EquationPart.Left)
            {
                if (_numberA != null && (_numberA != null || _numberA.Contains(",")))
                    TextBox.Text += "2";
                else
                    TextBox.Text = "2";
                _numberA += "2";
            }
            else if (currentPart == EquationPart.Right)
            {
                if (_numberB != null && (_numberB != null || _numberB.Contains(",")))
                    TextBox.Text += "2";
                else
                    TextBox.Text = "2";
                _numberB += "2";
            }
        }

        private void Button3_OnClick(object sender, RoutedEventArgs e)
        {
            if (currentPart == EquationPart.Left)
            {
                if (_numberA != null && (_numberA != null || _numberA.Contains(",")))
                    TextBox.Text += "3";
                else
                    TextBox.Text = "3";
                _numberA += "3";
            }
            else if (currentPart == EquationPart.Right)
            {
                if (_numberB != null && (_numberB != null || _numberB.Contains(",")))
                    TextBox.Text += "3";
                else
                    TextBox.Text = "3";
                _numberB += "3";
            }
        }

        private void Button4_OnClick(object sender, RoutedEventArgs e)
        {
            if (currentPart == EquationPart.Left)
            {
                if (_numberA != null && (_numberA != null || _numberA.Contains(",")))
                    TextBox.Text += "4";
                else
                    TextBox.Text = "4";
                _numberA += "4";
            }
            else if (currentPart == EquationPart.Right)
            {
                if (_numberB != null && (_numberB != null || _numberB.Contains(",")))
                    TextBox.Text += "4";
                else
                    TextBox.Text = "4";
                _numberB += "4";
            }
        }

        private void Button5_OnClick(object sender, RoutedEventArgs e)
        {
            if (currentPart == EquationPart.Left)
            {
                if (_numberA != null && (_numberA != null || _numberA.Contains(",")))
                    TextBox.Text += "5";
                else
                    TextBox.Text = "5";
                _numberA += "5";
            }
            else if (currentPart == EquationPart.Right)
            {
                if (_numberB != null && (_numberB != null || _numberB.Contains(",")))
                    TextBox.Text += "5";
                else
                    TextBox.Text = "5";
                _numberB += "5";
            }
        }

        private void Button6_OnClick(object sender, RoutedEventArgs e)
        {
            if (currentPart == EquationPart.Left)
            {
                if (_numberA != null && (_numberA != null || _numberA.Contains(",")))
                    TextBox.Text += "6";
                else
                    TextBox.Text = "6";
                _numberA += "6";
            }
            else if (currentPart == EquationPart.Right)
            {
                if (_numberB != null && (_numberB != null || _numberB.Contains(",")))
                    TextBox.Text += "6";
                else
                    TextBox.Text = "6";
                _numberB += "6";
            }
        }

        private void Button7_OnClick(object sender, RoutedEventArgs e)
        {
            if (currentPart == EquationPart.Left)
            {
                if (_numberA != null && (_numberA != null || _numberA.Contains(",")))
                    TextBox.Text += "7";
                else
                    TextBox.Text = "7";
                _numberA += "7";
            }
            else if (currentPart == EquationPart.Right)
            {
                if (_numberB != null && (_numberB != null || _numberB.Contains(",")))
                    TextBox.Text += "7";
                else
                    TextBox.Text = "7";
                _numberB += "7";
            }
        }

        private void Button8_OnClick(object sender, RoutedEventArgs e)
        {
            if (currentPart == EquationPart.Left)
            {
                if (_numberA != null && (_numberA != null || _numberA.Contains(",")))
                    TextBox.Text += "8";
                else
                    TextBox.Text = "8";
                _numberA += "8";
            }
            else if (currentPart == EquationPart.Right)
            {
                if (_numberB != null && (_numberB != null || _numberB.Contains(",")))
                    TextBox.Text += "8";
                else
                    TextBox.Text = "8";
                _numberB += "8";
            }
        }

        private void Button9_OnClick(object sender, RoutedEventArgs e)
        {
            if (currentPart == EquationPart.Left)
            {
                if (_numberA != null && (_numberA != null || _numberA.Contains(",")))
                    TextBox.Text += "9";
                else
                    TextBox.Text = "9";
                _numberA += "9";
            }
            else if (currentPart == EquationPart.Right)
            {
                if (_numberB != null && (_numberB != null || _numberB.Contains(",")))
                    TextBox.Text += "9";
                else
                    TextBox.Text = "9";
                _numberB += "9";
            }
        }

        private void DivideButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (_numberA != null && _numberB != null) _numberA = CalculateResult(_numberA, _numberB, _operator);
            TextBox.Text = "/";
            _operator = '/';
            currentPart = EquationPart.Right;
        }

        private void MultiplyButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (_numberA != null && _numberB != null) _numberA = CalculateResult(_numberA, _numberB, _operator);
            TextBox.Text = "*";
            _operator = '*';
            currentPart = EquationPart.Right;
        }

        private void SubstractButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (_numberA != null && _numberB != null) _numberA = CalculateResult(_numberA, _numberB, _operator);
            TextBox.Text = "-";
            _operator = '-';
            currentPart = EquationPart.Right;
        }

        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (_numberA != null && _numberB != null)
            {
                _numberA = CalculateResult(_numberA, _numberB, _operator);
                _numberB = null;
            }

            TextBox.Text = "+";
            _operator = '+';
            currentPart = EquationPart.Right;
        }

        private void CalculateButton_OnClick(object sender, RoutedEventArgs e)
        {
            var result = CalculateResult(_numberA, _numberB, _operator);
            TextBox.Text = result;
            _numberA = result;
            _numberB = null;
            _operator = null;
        }

        private string CalculateResult(string numberA, string numberB, char? @operator)
        {
            try
            {
                var a = Convert.ToDouble(numberA);
                var b = Convert.ToDouble(numberB);
                switch (_operator)
                {
                    case '+':
                        return (a + b).ToString(CultureInfo.InvariantCulture);

                    case '-':
                        return (a - b).ToString(CultureInfo.InvariantCulture);

                    case '*':
                        return (a * b).ToString(CultureInfo.InvariantCulture);

                    case '/':
                        return (a / b).ToString(CultureInfo.InvariantCulture);
                }
            }
            catch (Exception)
            {
                Console.WriteLine(@"Error!");
            }

            return "Error!";
        }

        private void DotButton_OnClick(object sender, RoutedEventArgs e)
        {
            TextBox.Text += ",";
            if (_operator == null)
                _numberA += ",";
            else
                _numberB += ",";
        }
    }
}