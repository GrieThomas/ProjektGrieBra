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
        CustomerDatabase myDatabase1;
        private string path = @"..\..\..\CustomerData.crypt";
        private string passwordPath = @"..\..\..\initFile.crypt";

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
                //hpEntryErrors.SetHelpString(txtboxFname, ex.Message);
                //toolTip1.SetToolTip(txtboxFname, ex.Message);
                //tpErrorMsg.Show(ex.Message,txtboxFname);
                //tpErrorMsg.SetToolTip(txtboxFname, ex.Message);
            }

            try
            {
                Customer.IsNameCorrect(txtboxLname.Text);
            }
            catch (Exception ex)
            {
                error = true;
                epErrorMessage.SetError(txtboxLname, ex.Message);
                //tpErrorMsg.Show(ex.Message, txtboxLname);
            }

            try
            {
                Customer.CheckEmail(txtMail.Text);
            }
            catch (Exception ex)
            {
                error = true;
                epErrorMessage.SetError(txtMail, ex.Message);
                //tpErrorMsg.Show(ex.Message, txtMail);
            }

            if (!error)
            {
                myDatabase1.AddCustomer(txtboxFname.Text, txtboxLname.Text, txtMail.Text);
                myDatabase1.StoreCSVData(path);
                DialogResult = DialogResult.OK;
            }
            //epErrorMessage.Clear();

            //this.Close();



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
            //string text;

            while (!sr.EndOfStream)
            {
                //Console.WriteLine(sr.ReadLine());

                //text = sr.ReadLine();
                //languageData.Add(text);

                for (int i = 0; i < languageData.Length; i++)
                {
                    languageData[i] = sr.ReadLine();
                }

            }
            sr.Close();

        }

        private void txtMail_Validating(object sender, CancelEventArgs e)
        {
            //try
            //{
            //    Customer.CheckEmail(txtMail.Text);
            //    epErrorMessage.Clear();
            //}
            //catch (Exception ex)
            //{
            //    epErrorMessage.SetError(txtMail, ex.Message);
            //    e.Cancel = false;

            //}
        }

        private void btnOk_Validated(object sender, EventArgs e)
        {
            //btnOk.Enabled = true;
        }

        private void txtMail_Validated(object sender, EventArgs e)
        {
            //btnOk.Enabled = true;
        }

        private void txtboxFname_Enter(object sender, EventArgs e)
        {

        }

        private void txtboxFname_Validating(object sender, CancelEventArgs e)
        {

        }


    }
}
