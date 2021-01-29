using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace FinaAssignment.Feature
{
    public class Format : ObjectDemo
    {
        private FontStyle fontStyle;
       
        public FontStyle FontStyle 
        {
            get { return fontStyle; }
            set { OnPropertyChanged(ref fontStyle, value); }
        }

        private FontWeight fontWeight;
        public FontWeight FontWeight
        {
            get { return fontWeight; }
            set { OnPropertyChanged(ref fontWeight, value); }
        }


        private FontFamily fontWFamily;
        public FontFamily FontFamily
        {
            get { return fontWFamily; }
            set { OnPropertyChanged(ref fontWFamily, value); }
        }


        private TextWrapping textWrapping;
        public TextWrapping TextWrapping
        {
            get { return textWrapping; }
            set
            {
                OnPropertyChanged(ref textWrapping,value);
                IsWrapped = value == TextWrapping.Wrap ? true : false;
            }
        }

        private bool isWrapped;
        public bool IsWrapped
        {
            get { return isWrapped; }
            set { OnPropertyChanged(ref isWrapped, value); }
        }

        private double size;
        public double Size
        {
            get { return size; }
            set 
            {
                OnPropertyChanged(ref size, value);
            }
        }
    }
}
