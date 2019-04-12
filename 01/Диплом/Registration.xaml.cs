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
using System.Windows.Shapes;

namespace Диплом
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        Window win;
        public Registration(MainWindow main)
        {
            InitializeComponent();
            this.win = main;
            
        }
        string answer;

        private void Reister_Click(object sender, RoutedEventArgs e)
        {
            Sql s = new Sql();
            answer = s.Register(this);
            if (answer == "succesfull")
            {
                MessageBox.Show("Регистрация прошла успешно, теперь вы можете войти");
                
                Close();
            
            }
            else
            {
                MessageBox.Show("Ошибка регистрации");
                Close();
            }
            
        }

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

      
        
    }
}
