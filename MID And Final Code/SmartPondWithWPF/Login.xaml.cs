using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        string userError;
        string passError;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public Login()
        {
            InitializeComponent();
        }
        private void btn_reset(object sender, EventArgs e)
        {
            username.Text = "";
            password.Password = "";
        }
        private void button_GoLogin(object sender, RoutedEventArgs e)
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
            if (password.Password == "")
            {
                passError = "Password is Required";
                Upass.Content = passError;
            }
            else
            {
                Upass.Content = "";
            }
            if (username.Text != "" && password.Password != "")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9NPUJOF;Initial Catalog=FishFarm;Integrated Security=True");
                try
                {
                    con.Open();
                    string newcon = "select UserName from UserAuth where UserName='" + username.Text + "' and Password='" + password.Password + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(newcon, con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    if(dt.Rows.Count>=1)
                    {
                        this.Hide();
                        string UserNam = username.Text.ToString();
                        FishFarmAdd entry = new FishFarmAdd(UserNam);
                        entry.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login Credential");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "Something went wrong!!!");
                }
                finally
                {
                    con.Close();
                }
          
            }
        }

    }
}
