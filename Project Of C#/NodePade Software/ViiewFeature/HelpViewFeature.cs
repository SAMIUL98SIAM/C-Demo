using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FinaAssignment.ViiewFeature
{
    public class HelpViewFeature : ObjectDemo
    {
        public ICommand HelpCommmand { get; }
        public HelpViewFeature()
        {
            HelpCommmand = new Command(DisplayAbout);
        }
        private void  DisplayAbout()
        {

        }
    }
}
