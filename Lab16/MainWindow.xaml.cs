using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Lab16
{
   
    public partial class MainWindow : Window
    {
        readonly DispatcherTimer _timer1;
        readonly DispatcherTimer _timer2;
        private bool _showMessage = false;
        private int _counter = 1;

        public MainWindow()
        {
            InitializeComponent();
            _timer1 = new DispatcherTimer();
            _timer1.Tick += new EventHandler(timer_tick);
            _timer1.Interval = new TimeSpan(0, 0, 3);
            _timer1.Start();
            _timer2 = new DispatcherTimer();
            _timer2.Tick += new EventHandler(timer2_tick);
            _timer2.Interval = new TimeSpan(0, 0, 1);
        }

        private void timer_tick(object sender, EventArgs e)
        {
            _timer1.Interval = new TimeSpan(0, 0, 1);
            if (_showMessage)
            {
                base.Title = "Press 'OK' button";
                _showMessage = false;
            }
            else
            {
                base.Title = "";
                _showMessage = true;
            }
            _counter++;
            if (_counter > 8)
            {
                _timer1.Stop();
                _showMessage = false;
            }
        }

        private void timer2_tick(object sender, EventArgs e)
        {
            if (_showMessage)
            {
                base.Title = "'OK' will never be pressed!";
                _showMessage = false;
            }
            else
            {
                base.Title = "";
                _showMessage = true;
            }
            _counter++;
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (OkButton.Margin.Left < 1)
            {
                OkButton.Margin = new Thickness(OkButton.Margin.Left + 100, OkButton.Margin.Top, 0, 0);
            }
            if (OkButton.Margin.Left + OkButton.Width + 10 > base.Width)
            {
                OkButton.Margin = new Thickness(base.Width - 100 - OkButton.Width, OkButton.Margin.Top, 0, 0);
            }
            if (OkButton.Margin.Top < 1)
            {
                OkButton.Margin = new Thickness(OkButton.Margin.Left, OkButton.Margin.Top + 100, 0, 0);
            }
            if (OkButton.Margin.Top + OkButton.Height + 40 > base.Height)
            {
                OkButton.Margin = new Thickness(OkButton.Margin.Left, base.Height - 100 - OkButton.Height, 0, 0);
            }
            if (e.GetPosition(Canvas).X > OkButton.Margin.Left - 20
                && e.GetPosition(Canvas).Y > OkButton.Margin.Top - 20
                && e.GetPosition(Canvas).X < OkButton.Margin.Left + OkButton.Width / 2
                && e.GetPosition(Canvas).Y < OkButton.Margin.Top + OkButton.Height / 2)
            {
                OkButton.Margin = new Thickness(OkButton.Margin.Left + 1, OkButton.Margin.Top + 1, 0, 0);
                ChangeSize();
            }
            if (e.GetPosition(Canvas).X > OkButton.Margin.Left - 15
                && e.GetPosition(Canvas).X < OkButton.Margin.Left + OkButton.Width / 2
                && e.GetPosition(Canvas).Y > OkButton.Margin.Top + OkButton.Height / 2
                && e.GetPosition(Canvas).Y < OkButton.Margin.Top + OkButton.Height + 20)
            {
                OkButton.Margin = new Thickness(OkButton.Margin.Left + 5, OkButton.Margin.Top - 5, 0, 0);
                ChangeSize();
            }
            if (e.GetPosition(Canvas).X > OkButton.Margin.Left + OkButton.Width / 2
                && e.GetPosition(Canvas).X < OkButton.Margin.Left + OkButton.Width + 20
                && e.GetPosition(Canvas).Y > OkButton.Margin.Top + OkButton.Height / 2
                && e.GetPosition(Canvas).Y < OkButton.Margin.Top + OkButton.Height + 20)
            {
                OkButton.Margin = new Thickness(OkButton.Margin.Left - 5, OkButton.Margin.Top - 5, 0, 0);
                ChangeSize();
            }
            if (e.GetPosition(Canvas).X > OkButton.Margin.Left + OkButton.Width / 2
                && e.GetPosition(Canvas).X < OkButton.Margin.Left + OkButton.Width + 20
                && e.GetPosition(Canvas).Y < OkButton.Margin.Top + OkButton.Height / 2
                && e.GetPosition(Canvas).Y > OkButton.Margin.Top - 20)
            {
                OkButton.Margin = new Thickness(OkButton.Margin.Left - 5, OkButton.Margin.Top + 5, 0, 0);
                ChangeSize();
            }
        }

        private void ChangeSize()
        {
            if (OkButton.Width > 0.1 && OkButton.Height > 0.1)
            {
                OkButton.Width = OkButton.Width - 0.1;
                OkButton.Height = OkButton.Height - 0.1;
            }
            else
            {
                OkButton.Visibility = Visibility.Hidden;
                _timer2.Start();
                timer2_tick(null, null);
            }
        }

        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            OkButton.Margin = new Thickness(CancelButton.Margin.Left + 200, CancelButton.Margin.Top + 200, 0, 0);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 'OK' has been clicked");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}