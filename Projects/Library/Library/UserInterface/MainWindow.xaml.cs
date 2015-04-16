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
using Library;

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Library.Library.Instance.Start();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Login.Init(this.Username.Text, this.Password.Password);
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
                return;
            }
            var o = new UserPanel();
            o.Show();
            this.Close();
        }

        private void Register_Click(object sender, RoutedEventArgs e) //TODO add more validations
        {
            if (this.RegisterPassword.Password == this.RePassword.Password)//check passwords 
            {
                if (!FileManager.UserExist(RegisterUsername.Text))
                {
                    FileManager.CreateUserFile(RegisterUsername.Text, RegisterPassword.Password);
                    MessageBox.Show("Registration successful.");
                    RegisterPassword.Clear();
                    RePassword.Clear();
                    RegisterUsername.Clear();
                }
                else
                {
                    MessageBox.Show("Username already exist!");
                }
            }
            else
            {
                MessageBox.Show("Passwords does not match!");
            }
        }
    }
}
