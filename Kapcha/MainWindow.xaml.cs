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

namespace Kapcha
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnKapcha_Click(object sender, RoutedEventArgs e)
        {
            txtbKapcha.Text = null;
            Random rnd = new Random();

            string strLogin = string.Empty;
            string genLogin = string.Empty;

            for (int i = 0; i < 10; i++)
            {
                strLogin += (char)rnd.Next(97, 123);

            }


            txtbKapcha.Text = strLogin;
        }
    }
}
