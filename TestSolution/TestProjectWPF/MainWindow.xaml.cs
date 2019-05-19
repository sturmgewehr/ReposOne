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
using TestProjectWPF.Models;

namespace TestProjectWPF
{
    public partial class MainWindow : Window
    {
        UserViewModel user;

        public MainWindow()
        {
            user = new UserViewModel();
            InitializeComponent();
            this.DataContext = user;
            int a = 20;
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Login:{user.Login}\nPassword:{user.Password}\nConfirm password:{user.ConfirmPassword}\nPhone number:{user.Phone}");
        }

    }
}
