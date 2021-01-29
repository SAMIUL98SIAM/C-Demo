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
using System.Data.SqlClient;
namespace LoginDemo
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        string ussErr, passErr;
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(uName.Text=="")
            {
                ussErr = "UserName is required";
                userError.Content = ussErr;
            }
            else
            {
                userError.Content = "";
            }
            if (uPass.Password == "")
            {
                passErr = "Password is required";
                passError.Content = passErr;
            }
            else
            {
                passError.Content = "";
            }
            if(uName.Text!="" && uPass.Password!="")
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-9NPUJOF;Initial Catalog=Project;Integrated Security=True");
                try
                {

                    sqlConnection.Open();
                    string query = "Select count(*) from UserTable where UserName= '" + uName.Text + "' AND Password= '" + uPass.Password + "'  ";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    int a = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    if (a == 1)
                    {
                        string userName = uName.Text.ToString();
                        UserView userView = new UserView(userName);
                        userView.Show();
                        this.Hide();
                       // MessageBox.Show("Valid");
                    }
                    else
                    {
                        MessageBox.Show("Invalid");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
             
        }
    }
}
