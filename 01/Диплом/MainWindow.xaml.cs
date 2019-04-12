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
            if (status_cod == 1)
            {
                Login.BorderBrush = Brushes.Green;
                Password.BorderBrush = Brushes.Green;
                _Login(s.Name, s.Roly);
            }
            else
            {
                if (status_cod == 2)
                {
                    
                    Login.BorderBrush = Brushes.Green;
                    Password.BorderBrush = Brushes.IndianRed;
                }
                else
                {
                    Password.BorderBrush = Brushes.IndianRed;
                    Login.BorderBrush = Brushes.IndianRed;
                }
            }
        }
        private void _Login(string Name_, string Roly_)
        {
            Sotr s = new Sotr();
            switch(Roly_)
            {
                case "Сотрудник":
                    s.Hi.Text = Name_;
                    s.Name__ = Name_;
                    s.Roly = Roly_;
                    s.Show();
                    break;
                //case "Техник":
                //    //

            }
        }

        private void Reister_Click(object sender, RoutedEventArgs e)
        {
            Registration r = new Registration(this);
            r.Show();
        }
    }
}
