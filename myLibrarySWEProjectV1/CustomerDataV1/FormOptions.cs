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
        public string backupFilePath = null;
        private string path = @"..\..\..\CustomerData.crypt";
        private string passwordPath = @"..\..\..\init\passwordFile.crypt";
        private CustomerDatabase myDatabase;
        public string password;


        public FormOptions()
        {
            InitializeComponent();
            myDatabase = new CustomerDatabase();
            myDatabase.ReadPassword(passwordPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            backupFilePath = openFileDialog1.FileName;
            //backupFilePath = backupPath + "\\" + openFileDialog1.SafeFileName;
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



            if (tbxOldPass.Text.Equals(myDatabase.Password))
            {
                password = tbxNewPass.Text;
                myDatabase.ChangePassword(passwordPath, path, password);
                Close();
            }
            else
            {
                MessageBox.Show("Old Password is incorrect");
            }

        }

        private void FormOptions_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadBackup_Click(object sender, EventArgs e)
        {

            try
            {
                if (backupFilePath != null)
                {
                    myDatabase.readStoredData(backupFilePath);
                    myDatabase.StoreCSVData(path);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
