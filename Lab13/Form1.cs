using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab13
{
    public partial class Form1 : Form
    {
        private const int ButtonCounter = 16;
        private int _numberNow = 1;
        private readonly List<int> _numbers;
        private readonly Random _random;
        private readonly Stopwatch _stopWatch;
        private readonly HashSet<int> _tempNumbers;

        public Form1()
        {
            InitializeComponent();
            _numbers = new List<int>(ButtonCounter);
            _tempNumbers = new HashSet<int>(ButtonCounter);
            _random = new Random();
            _stopWatch = new Stopwatch();
            CreateButtons();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != string.Empty)
            {
                ComboBox.Items.Add(TextBox.Text);
                TextBox.BackColor = Color.White;
                TextBox.ForeColor = Color.Black;
                TextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(@"Enter text!");
                TextBox.BackColor = Color.Red;
                TextBox.ForeColor = Color.White;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != string.Empty)
            {
                if (ComboBox.Items.Contains(TextBox.Text))
                {
                    ComboBox.Items.Remove(TextBox.Text);
                    TextBox.BackColor = Color.White;
                    TextBox.ForeColor = Color.Black;
                    TextBox.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show(@"Text like this is not exists.");
                    TextBox.BackColor = Color.Red;
                    TextBox.ForeColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show(@"Enter text!");
                TextBox.BackColor = Color.Red;
                TextBox.ForeColor = Color.White;
            }
        }

        private void CreateButtons()
        {
            _numbers.AddRange(Enumerable.Range(1, ButtonCounter));

            var size = 40;
            for (var i = 0; i < 4; i++)
            for (var j = 0; j < ButtonCounter / 4; j++)
            {
                var button = new Button
                {
                    Location = new Point((size + 10) * i, (size + 10) * j),
                    Size = new Size(size, size)
                };
                button.Click += ButtonClick;
                var number = Randomize(0, ButtonCounter);
                _tempNumbers.Add(number);

                button.Text = number.ToString();
                PanelNumbers.Controls.Add(button);
            }

            _tempNumbers.Clear();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (_numberNow == int.Parse(button?.Text ?? string.Empty))
            {
                if (_numberNow == 1) _stopWatch.Start();
                if (_numberNow == 16)
                {
                    var ts = _stopWatch.Elapsed;
                    var elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
                    _stopWatch.Reset();
                    ResetButton();
                    return;
                }

                if (button != null) button.Visible = false;
                _numberNow++;
                ChangeNumber();
            }
            else
            {
                ResetButton();
            }
        }

        private void ResetButton()
        {
            _numberNow = 1;
            PanelNumbers.Controls.Clear();
            CreateButtons();
        }

        private void ChangeNumber()
        {
            foreach (var item in PanelNumbers?.Controls)
            {
                var button = item as Button;
                if (button != null && button.Visible)
                {
                    var number = Randomize(_numberNow - 1, ButtonCounter);
                    _tempNumbers.Add(number);
                    button.Text = number.ToString();
                }
            }

            _tempNumbers.Clear();
        }

        private int Randomize(int min, int max)
        {
            int number;
            do
            {
                var index = _random.Next(min, max);
                number = _numbers[index];
            } while (_tempNumbers.Contains(number));

            return number;
        }
    }
}