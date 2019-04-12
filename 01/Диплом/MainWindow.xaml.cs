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


namespace Диплом
{
    
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string L { get; set; }
        public string P { get; set; }
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            Sql s = new Sql();
            s.Login = Login.Text;
            s.Password = Password.Password;
            int status_cod = s.Authorization();
            string _Name = s.Name;
            string _Roly = s.Roly;
            Sotr so = new Sotr();
            so.Hi.Text = so.Hi.Text + _Name;
            so.Show();
            Hide();
        }

        private void Reister_Click(object sender, RoutedEventArgs e)
        {
            Registration r = new Registration(this);
            r.Show();
            
            
            
        }
    }
}
