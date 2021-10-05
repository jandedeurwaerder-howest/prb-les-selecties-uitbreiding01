using System;
using System.Collections.Generic;
using System.Diagnostics;
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


namespace Prb.Selection.Gambling.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int attempts;
        Random rnd = new Random();
        int toGuess;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StartUp();
        }
        void StartUp()
        {
            toGuess = rnd.Next(1, 11);
            Debug.WriteLine("Te raden : " + toGuess);
            attempts = 0;
            btnRefresh.Visibility = Visibility.Hidden;
            btnGuess.Visibility = Visibility.Visible;
            lblGuesses.Content = "";
            txtGuess.IsEnabled = true;
            txtGuess.Text = "";
            txtGuess.Focus();
        }

        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {
            attempts++;
            //++attempts;
            //attempts = attempts + 1;
            //attempts += 1;
            int.TryParse(txtGuess.Text, out int guess);
            if(guess == toGuess)
            {
                lblGuesses.Content += $"Je hebt het getal {toGuess} in {attempts} pogingen geraden";
                btnGuess.Visibility = Visibility.Hidden;
                btnRefresh.Visibility = Visibility.Visible;
                txtGuess.IsEnabled = false;
            }
            else
            {
                lblGuesses.Content += $"{guess} is niet correct\n";
                txtGuess.Text = "";
                txtGuess.Focus();
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            StartUp();
        }
    }
}
