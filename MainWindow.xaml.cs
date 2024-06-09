using System.IO;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Media;

namespace Notepad_Pro
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // New file operation
        private void NewFile(object sender, RoutedEventArgs e)
        {
            MainTextBox.Clear();
        }

        // Open file operation
        private void OpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                MainTextBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        // Save file operation
        private void SaveFile(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, MainTextBox.Text);
            }
        }

        // Close application
        private void CloseApp(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // Change to light theme
        private void OnLightThemeClick(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.White;
            MainTextBox.Background = Brushes.White;
            MainTextBox.Foreground = Brushes.Black;
        }

        // Change to dark theme
        private void OnDarkThemeClick(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Black;
            MainTextBox.Background = Brushes.Black;
            MainTextBox.Foreground = Brushes.White;
        }

        // Change to solarized light theme
        private void OnSolarizedLightClick(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.AliceBlue;
            MainTextBox.Background = Brushes.AliceBlue;
            MainTextBox.Foreground = Brushes.DarkSlateGray;
        }

        // Change to solarized dark theme
        private void OnSolarizedDarkClick(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.DarkSlateGray;
            MainTextBox.Background = Brushes.DarkSlateGray;
            MainTextBox.Foreground = Brushes.AliceBlue;
        }

        // Change to Monokai theme
        private void OnMonokaiClick(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Gray;
            MainTextBox.Background = Brushes.Gray;
            MainTextBox.Foreground = Brushes.Cyan;
        }

        // Change to Dracula theme
        private void OnDraculaClick(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Black;
            MainTextBox.Background = Brushes.Black;
            MainTextBox.Foreground = Brushes.Purple;
        }

        // Change to Nord theme
        private void OnNordClick(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Navy;
            MainTextBox.Background = Brushes.Navy;
            MainTextBox.Foreground = Brushes.LightSkyBlue;
        }
    }
}
