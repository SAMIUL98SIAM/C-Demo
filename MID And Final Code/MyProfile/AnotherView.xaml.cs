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

namespace MyProfile
{
    /// <summary>
    /// Interaction logic for AnotherView.xaml
    /// </summary>
    public partial class AnotherView : Window
    {
        public AnotherView(string userName)
        {
            InitializeComponent();
             name.Content = "This is Mr. " + userName + "Profile's ";
        }
    }
}
