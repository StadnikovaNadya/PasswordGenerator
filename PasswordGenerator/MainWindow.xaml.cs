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

namespace PasswordGenerator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string pass = "qwertyuipasdfghjkzxcvbnm1234567890QWERTYUIPASDFGHJKZXCVBNM";
            int kol= 4;
            string result = "";
            Random rnd = new Random();
            int lng = pass.Length;

            for (int i=0; i<kol; i++)
            {
                result += pass[rnd.Next(lng)];
            }
            TextBox.Text = result;
        }
    }
}
