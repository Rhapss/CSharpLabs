using System;
using System.IO;
using System.Text.Json;
using System.Windows;

namespace Lab19
{
    internal class WindowSettings
    {
        public bool EatCheckBox { set; get; }
        public bool SleepCheckBox { set; get; }
        public bool CodeCheckBox { set; get; }
        public string Text { set; get; }
        public double ScreenWidth { set; get; }
        public double ScreenHeight { set; get; }
    }

    public partial class MainWindow : Window
    {
        private readonly string fileName = @"C:\data.json";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void WriteDataButton_OnClick(object sender, RoutedEventArgs e)
        {
            var data = new WindowSettings();
            data.EatCheckBox = (bool) EatCheckBox.IsChecked;
            data.SleepCheckBox = (bool) SleepCheckBox.IsChecked;
            data.CodeCheckBox = (bool) CodeCheckBox.IsChecked;

            data.Text = Text.Text;

            data.ScreenHeight = Height;
            data.ScreenWidth = Width;

            try
            {
                using var streamWriter = new StreamWriter(fileName);
                var settings = JsonSerializer.Serialize(data);
                streamWriter.Write(settings);
                MessageBox.Show($"Data saved in {fileName}");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Failed. Try Again");
            }
        }
    }
}