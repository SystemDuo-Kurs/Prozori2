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

namespace Prozori2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Osoba o = new();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = o;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(o.Ime);
        }
    }
    public class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}
