using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace SmartPondWithWPF
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        string userError;
        string phoneError;
        string passError;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_reset(object sender, EventArgs e)
        {
            username.Text = "";
            phoneno.Text = "";
            password.Password = "";
        }

     
        private void button_GoSignUp(object sender, RoutedEventArgs e)
        {

            if (username.Text == "")
            {
                userError = "UserName is Required";
                Uname.Content = userError;
            }
            else
            {
                Uname.Content = "";
            }
            if (phoneno.Text == "")
            {
                phoneError = "PhoneNo is Required";
                Uphone.Content = phoneError;           }
            else
            {
                Uphone.Content = "";
            }
            if (password.Password == "")
            {
                passError = "Password is Required";
                Upass.Content = passError;
            }
            else
            {
                Upass.Content = "";
            }
            if (username.Text!="" && phoneno.Text!= "" && password.Password!="")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9NPUJOF;Initial Catalog=FishFarm;Integrated Security=True");
                try
                {
                    con.Open();
                    string newcon = "insert into [UserAuth] (UserName, PhoneNo, Password) VALUES ('" + username.Text + "','" + phoneno.Text + "','" + password.Password + "')";
                    SqlCommand cmd = new SqlCommand(newcon, con);
                    int a = Convert.ToInt32(cmd.ExecuteNonQuery());
                    if(a==1)
                    {
                        this.Hide();
                        Login entry = new Login();
                        entry.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Crediental");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + " Something error");
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void sub_login(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Login entry = new Login();
            entry.ShowDialog();
            this.Close();
        }

    }
}
