using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab14
{
    public partial class Form1 : Form
    {
        private bool _gameOver;
        private readonly int Shift = 20;
        private bool _showName = true;
        private int _timerCounter;
        private readonly int TimerCounterMax = 8;
        private int _x;
        private int _y;

        public Form1()
        {
            InitializeComponent();
            CreateAreas();
            ChangePanelPosition();
        }

        private void CreateAreas()
        {
            var color = Color.Transparent;
            var size = 20;
            Control[] panels = {
                new Panel {Size = new Size(size, size), BackColor = color, Tag = 0},
                new Panel {Size = new Size(OKButton.Size.Width, size), BackColor = color, Tag = 1},
                new Panel {Size = new Size(size, size), BackColor = color, Tag = 2},
                new Panel {Size = new Size(size, OKButton.Size.Height), BackColor = color, Tag = 3},
                new Panel {Size = new Size(size, size), BackColor = color, Tag = 4},
                new Panel {Size = new Size(OKButton.Size.Width, size), BackColor = color, Tag = 5},
                new Panel {Size = new Size(size, size), BackColor = color, Tag = 6},
                new Panel {Size = new Size(size, OKButton.Size.Height), BackColor = color, Tag = 7}
            };

            foreach (var control in panels) control.MouseMove += Panel_MouseMove;

            Controls.AddRange(panels);
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Panel panel)
            {
                OKButton.Location = GetNewLocation((int) panel.Tag);

                if (OKButton.Location.X + OKButton.Size.Width > Size.Width)
                    OKButton.Location = new Point(_x - OKButton.Size.Width, _y);
                else if (OKButton.Location.X < 0)
                    OKButton.Location = new Point(_x + OKButton.Size.Width, _y);
                else if (OKButton.Location.Y < 0)
                    OKButton.Location = new Point(_x, _y + OKButton.Size.Height);
                else if (OKButton.Location.Y + OKButton.Size.Height > Size.Height)
                    OKButton.Location = new Point(_x, _y - OKButton.Size.Height);

                ChangePanelPosition();
                OKButton.Size = new Size(OKButton.Size.Width - 1, OKButton.Size.Height - 1);

                if (OKButton.Size.Height == 0 && !_gameOver)
                {
                    Timer.Tick -= Timer_Tick;
                    Timer.Tick += Timer_Tick_Lose;
                    Timer.Interval = 800;
                    _gameOver = true;
                    Timer.Start();
                }
            }
        }

        private Point GetNewLocation(int area)
        {
            switch (area)
            {
                case 0:
                    return new Point(OKButton.Location.X + Shift, OKButton.Location.Y + Shift);
                case 1:
                    return new Point(OKButton.Location.X, OKButton.Location.Y + Shift);
                case 2:
                    return new Point(OKButton.Location.X - Shift, OKButton.Location.Y + Shift);
                case 3:
                    return new Point(OKButton.Location.X - Shift, OKButton.Location.Y);
                case 4:
                    return new Point(OKButton.Location.X - Shift, OKButton.Location.Y - Shift);
                case 5:
                    return new Point(OKButton.Location.X, OKButton.Location.Y - Shift);
                case 6:
                    return new Point(OKButton.Location.X + Shift, OKButton.Location.Y - Shift);
                case 7:
                    return new Point(OKButton.Location.X + Shift, OKButton.Location.Y);
                default:
                    return new Point(0, 0);
            }
        }

        private void ChangePanelPosition()
        {
            var points = new Point[8]
            {
                new Point(OKButton.Location.X - Shift, OKButton.Location.Y - Shift),
                new Point(OKButton.Location.X, OKButton.Location.Y - Shift),
                new Point(OKButton.Location.X + OKButton.Size.Width, OKButton.Location.Y - Shift),
                new Point(OKButton.Location.X + OKButton.Size.Width, OKButton.Location.Y),
                new Point(OKButton.Location.X + OKButton.Size.Width, OKButton.Location.Y + OKButton.Size.Height),
                new Point(OKButton.Location.X, OKButton.Location.Y + OKButton.Size.Height),
                new Point(OKButton.Location.X - Shift, OKButton.Location.Y + OKButton.Size.Height),
                new Point(OKButton.Location.X - Shift, OKButton.Location.Y)
            };

            foreach (var control in Controls)
                if (control is Panel panel)
                    panel.Location = points[(int) panel.Tag];
        }

        private void OKButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Button)
            {
                OKButton.Location = new Point(OKButton.Location.X + 30, OKButton.Location.Y + 30);
                ChangePanelPosition();
                OKButton.Size = new Size(OKButton.Size.Width - 1, OKButton.Size.Height - 1);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Timer.Tick += Timer_Tick;
            Timer.Interval = 800;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_showName)
            {
                Text = "";
                _showName = false;
            }
            else
            {
                Text = @"Натисніть кнопку “Ок”!!!";
                _showName = true;
            }

            if (_timerCounter == TimerCounterMax)
            {
                Text = @"Натисніть кнопку “Ок”!!!";
                _timerCounter = 0;
                Timer.Stop();
            }

            _timerCounter++;
        }

        private void Timer_Tick_Lose(object sender, EventArgs e)
        {
            if (_showName)
            {
                Text = "";
                _showName = false;
            }
            else
            {
                Text = @"Кнопка “Ок” не може бути натиснута";
                _showName = true;
            }
        }
    }
}