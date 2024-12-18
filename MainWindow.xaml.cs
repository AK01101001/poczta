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

namespace poczta
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cenaS="";
            string source="";
            if (a.IsChecked==true)
            {
                cenaS = "1";
                source = "pocztowka.png";
            }
            else if (b.IsChecked == true)
            {
                cenaS = "1.5";
                source = "list.png";
            }
            else if (c.IsChecked == true)
            {
                cenaS = "10";
                source = "paczka.png";
            }
            cena.Text = cenaS;
            image.Source = new BitmapImage(new Uri(source, UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (kod.Text.Length==5)
            {
                MessageBox.Show("Dobrze");
            }
            else
            {
                MessageBox.Show("nie");
            }
        }
    }
}
