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
using System.IO;

namespace CustomerDataV1
{
    public partial class FormAddPerson : Form
    {
        private CustomerDatabase myDatabase1;
        private string path = @"..\..\..\CustomerData.crypt";
        private string passwordPath = @"..\..\..\init\passwordFile.crypt";

        public string language;
        public string[] languageData = new string[10];

        public FormAddPerson()
        {
            InitializeComponent();
            myDatabase1 = new CustomerDatabase();
            myDatabase1.ReadPassword(passwordPath);
            myDatabase1.readStoredData(path);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool error = false;
            epErrorMessage.Clear();

            try
            {
                Customer.IsNameCorrect(txtboxFname.Text);
            }
            catch (Exception ex)
            {
                error = true;
                epErrorMessage.SetError(txtboxFname, ex.Message);
            }

            try
            {
                Customer.IsNameCorrect(txtboxLname.Text);
            }
            catch (Exception ex)
            {
                error = true;
                epErrorMessage.SetError(txtboxLname, ex.Message);
            }

            try
            {
                Customer.CheckEmail(txtMail.Text);
            }
            catch (Exception ex)
            {
                error = true;
                epErrorMessage.SetError(txtMail, ex.Message);
            }

            if (!error)
            {
                myDatabase1.AddCustomer(txtboxFname.Text, txtboxLname.Text, txtMail.Text);
                myDatabase1.StoreCSVData(path);
                DialogResult = DialogResult.OK;
            }
        }

        private void FormAddPerson_Load(object sender, EventArgs e)
        {
            LoadLanguageData(language);
            this.Text = languageData[0];
            lblFname.Text = languageData[1];
            lblLname.Text = languageData[2];
            lblEmail.Text = languageData[3];
            btnOk.Text = languageData[4];
            btnAbort.Text = languageData[5];
        }

        public void LoadLanguageData(string language)
        {
            StreamReader sr = new StreamReader(@"..\..\..\Languages\" + this.Name + language + ".txt");

            while (!sr.EndOfStream)
            {
                for (int i = 0; i < languageData.Length; i++)
                {
                    languageData[i] = sr.ReadLine();
                }
            }
            sr.Close();
        }
    }
}
