using FinaAssignment.Feature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FinaAssignment.ViiewFeature
{
    public class EditorViewFeature
    {
        public ICommand FormatCommnad { get; }
        public ICommand WrapCommnad { get; }

        public Format FormatModel { get; set; }
        public Documents DocumentsModel { get; set; }

        public EditorViewFeature(Documents documents)
        {
            DocumentsModel = documents;
            FormatModel = new Format();
            FormatCommnad = new Command(OpenStyleDialog);
            WrapCommnad = new Command(ToggleWrap);
        }

        private void OpenStyleDialog() 
        {
            var fontDialog = new FontDemo();
            fontDialog.DataContext = FormatModel;
            fontDialog.ShowDialog();
        }
        private void ToggleWrap()
        {
            if(FormatModel.TextWrapping==System.Windows.TextWrapping.Wrap)
            {
                FormatModel.TextWrapping = System.Windows.TextWrapping.NoWrap;
            }
            else
            {
                FormatModel.TextWrapping = System.Windows.TextWrapping.Wrap;
            }
        }
    }
}
