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

namespace SmartPondWithWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, SmartFishFarm2.io.ISensorIO
    {
        //declare a variable that will handle sensor data
        SmartFishFarm2.SmartPondsWithFiles smf = null;
        public MainWindow()
        {
            InitializeComponent();
            //initialize the sensor data handler/processor
            smf = new SmartFishFarm2.SmartPondsWithFiles(SmartFishFarm2.alldata.PondSize.MEDIUM, this);
        }

        public void showError(string err)
        {
            lblError.Content = err;
        }

        public void showMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        public void showMssg(string msg)
        {
            throw new NotImplementedException();
        }

        private void btnSaveSesorData_Click(object sender, RoutedEventArgs e)
        {
            SmartFishFarm2.alldata.Sensor s;
            s.data_value = 13.4;
            s.sensor_id = 22;
            s.sensor_type = SmartFishFarm2.alldata.sensortypes.PH;
            smf.saveSensorData(s);
        }
    }
}
