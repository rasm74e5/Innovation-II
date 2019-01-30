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

namespace Innovation_II
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

        private void Log_On_Click(object sender, RoutedEventArgs e)
        {
            Label1.Visibility = Visibility.Hidden;
            Label2.Visibility = Visibility.Hidden;
            Label3.Visibility = Visibility.Hidden;
            TextBox1.Visibility = Visibility.Hidden;
            TextBox2.Visibility = Visibility.Hidden;
            Log_On.Visibility = Visibility.Hidden;

            StartLabel1.Visibility = Visibility.Visible;
            Crome.Visibility = Visibility.Visible;
            Fronter.Visibility = Visibility.Visible;
            GDrev.Visibility = Visibility.Visible;
            Onenote.Visibility = Visibility.Visible;
            One_Drive.Visibility = Visibility.Visible;
            Tandhjul.Visibility = Visibility.Visible;
            Word.Visibility = Visibility.Visible;
        }
    }
}
