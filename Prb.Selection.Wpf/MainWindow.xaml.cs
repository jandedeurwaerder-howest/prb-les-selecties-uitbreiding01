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

namespace Prb.Selection.Wpf
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

        private void btnTestBool_Click(object sender, RoutedEventArgs e)
        {
            bool areYouReady = true;
            MessageBox.Show(areYouReady.ToString(), "Ben je klaar?");
        }

        private void btnTestNot_Click(object sender, RoutedEventArgs e)
        {
            bool areYouReady = false;
            areYouReady = !areYouReady;
            MessageBox.Show(areYouReady.ToString(), "Ben je klaar?");
        }
    }
}
