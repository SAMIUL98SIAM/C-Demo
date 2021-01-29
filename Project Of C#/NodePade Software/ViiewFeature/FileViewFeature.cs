using FinaAssignment.Feature;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FinaAssignment.ViiewFeature
{
    public class FileViewFeature
    {
        public Documents DocumentsModel { get; private set; }
        public ICommand newCommand { get; }
        public ICommand saveCommand { get; }
        public ICommand saveAsCommand { get; }
        public ICommand openCommand { get; }
        public FileViewFeature(Documents documents)
        {
            DocumentsModel = documents;
            newCommand = new Command(NewFile);
            openCommand = new Command(OpenFile);
            saveCommand = new Command(SaveFile);
            saveCommand = new Command(SaveFileAs);
            
        }
        public void NewFile()
        {
            DocumentsModel.FileName = string.Empty;
            DocumentsModel.FilePath = string.Empty;
            DocumentsModel.Text = string.Empty;
        }
        private void SaveFile()
        {
            File.WriteAllText(DocumentsModel.FilePath, DocumentsModel.Text);
        }
        private void SaveFileAs()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt";
            if(saveFileDialog.ShowDialog()==true)
            {
                DockFile(saveFileDialog);
                File.WriteAllText(saveFileDialog.FileName, DocumentsModel.Text);
            }
        }

        private void OpenFile()
        {
            var openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog()==true)
            {
                DockFile(openFileDialog);
                DocumentsModel.Text =  File.ReadAllText(openFileDialog.FileName);
            }
        }
        private void DockFile<T>(T dialog) where T : FileDialog
        {
            DocumentsModel.FilePath = dialog.FileName;
            DocumentsModel.FileName = dialog.SafeFileName;
        }
    }
    
}
