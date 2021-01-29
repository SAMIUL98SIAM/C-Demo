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
    /// Interaction logic for FishFarmAdd.xaml
    /// </summary>
    public partial class FishFarmAdd : Window
    {
        public FishFarmAdd(string UserNam)
        {
            InitializeComponent();
            nextname.Content = "Hey Mr." + UserNam + "Welcome to our Sytem";
            inTime.IsEnabled = false;
            sduration.IsEnabled = false;
            BindataUserName();
            TimeUpdater1();
            Bindata();
            TimeUpdater();
        }

        

        async void TimeUpdater()
        {
            inTime.Text = DateTime.Now.ToString();
            outTime.Text = DateTime.Now.ToString();
            await Task.Delay(1000);
        }

        async void TimeUpdater1()
        {
            while(true)
            {
                timeUp.Content = DateTime.Now.ToString();
                await Task.Delay(1000);
            }
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-9NPUJOF;Initial Catalog=FishFarm;Integrated Security=True");

        private void save_Click(Object Sender, RoutedEventArgs e)
        {
            if (sid.Text != "" && stype.Text != "" && inTime.Text != "" && outTime.Text != "" && sdata.Text != "" && sduration.Text != "")
            {
                try
                {
                    con.Open();
                    BindataUserName();
                    string newcon = "insert into FishAdd (SensorID, SensorType, SensorData, Duration) values ('" + sid.Text + "','" + stype.Text + "','" + sdata.Text + "','" + sduration.Text + "')";
                    SqlCommand cmd = new SqlCommand(newcon, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Inserted!!!");
                    Bindata();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid Crediential!!");
            }
        }

        void BindataUserName()
        {
            SqlCommand cmd = new SqlCommand("select UserName from UserAuth where UserName='UserName'");
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
        }

        void Bindata()
        {
            SqlCommand cmd = new SqlCommand("select * from FishAdd", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            datagridview1.ItemsSource = dt.DefaultView;
        }
    }
}
