using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myLibrarySWEProject;

namespace CustomerDataV1
{
    public partial class FormOptions : Form
    {
        private string backupPath = @"..\..\..\backups";
        public string backupFilePath;
        private string path = @"..\..\..\CustomerData.crypt";
        private CustomerDatabase myDatabase;


        public FormOptions()
        {
            InitializeComponent();
            myDatabase = new CustomerDatabase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            backupFilePath = backupPath + "\\" + openFileDialog1.SafeFileName;
            textBox1.Text = backupFilePath;

        }

        private void btnBackupPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            backupPath = folderBrowserDialog1.SelectedPath;
            
            textBox1.Text = backupPath;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            myDatabase.readStoredData(backupFilePath);
          
            myDatabase.StoreCSVData(path);

        }


    }
}
