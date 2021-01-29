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

namespace MyProfile
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        string uError, pError, mError;
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_remove(object sender, RoutedEventArgs e)
        {
            uName.Text = "";
            uPass.Password = "";
            uMail.Text = "";
        }
        private void Button_Click(object sender,RoutedEventArgs e)
        {
            if (uName.Text == "")
            {
                uError = "UserName is Required";
                userError.Content = uError;
            }
            else
            {
                userError.Content = "";
            }

            if (uPass.Password == "")
            {
                pError = "Password is Required";
                passError.Content = pError;
            }
            else
            {
                passError.Content = "";
            }
            if (uMail.Text == "")
            {
                mError = "Email is Required";
                mailError.Content = mError;
            }
            else
            {
                mailError.Content = "";

            }
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-9NPUJOF;Initial Catalog=Project2;Integrated Security=True");
            try
            {
                sqlConnection.Open();
                string query = "Select count(*) from User2 where UserName= '" + uName.Text + "' AND Password='" + uPass.Password + "' AND Email=  '" + uMail.Text + "' ";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                int a = Convert.ToInt32(sqlCommand.ExecuteScalar());
                if (a == 1)
                {
                    //MessageBox.Show("Valid");
                    string userName = uName.ToString();
                    AnotherView anotherView = new AnotherView(userName);
                    anotherView.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
            }
            catch(Exception ex)
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
