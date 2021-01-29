using FinaAssignment.Feature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaAssignment.ViiewFeature
{
    public class MainViewFeature
    {
        private Documents documents;
        public EditorViewFeature editorViewFeature { get; set; }
        public FileViewFeature fileViewFeature { get; set; }
        public HelpViewFeature helpViewFeature { get; set; }
        public MainViewFeature()
        {
            documents = new Documents();
            helpViewFeature = new HelpViewFeature();
            editorViewFeature = new EditorViewFeature(documents);
            fileViewFeature = new FileViewFeature(documents);
        }
    }
}
