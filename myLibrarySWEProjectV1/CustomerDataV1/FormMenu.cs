using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myLibrarySWEProject;

namespace CustomerDataV1
{
    public partial class FormMenu : Form
    {
        private CustomerDatabase myDatabase;
        private string path = @"..\..\..\CustomerData.crypt";
        public string passwordPath = @"..\..\..\init\passwordFile.crypt";
        private string backupFolderPath = @"..\..\..\backups\";
        public string language;
        public string[] languageData = new string[30];
        bool FNameInvalid = false;
        bool LNameInvalid = false;

        public FormMenu()
        {
            InitializeComponent();
            myDatabase = new CustomerDatabase();
            myDatabase.ReadPassword(passwordPath);
            myDatabase.readStoredData(path);

            dataGridView2.Columns.Add("1", "Customer ID");
            dataGridView2.Columns.Add("2", "First Name");
            dataGridView2.Columns.Add("3", "Last Name");
            dataGridView2.Columns.Add("4", "E-Mail");
            dataGridView2.Columns.Add("5", "Account balance");
            dataGridView2.Columns.Add("6", "Last change");
            // btnFindPers.Enabled = false;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            LoadLanguageData(language);

            btnFindPers.Text = languageData[0];
            btnFindPersEmail.Text = languageData[1];
            lblFname.Text = languageData[2];
            lblLname.Text = languageData[3];
            lblEmail.Text = languageData[4];
            btnChangeAttribut.Text = languageData[5];
            btnMoneyInOut.Text = languageData[6];
            btnAdPers.Text = languageData[7];
            btnshowall.Text = languageData[8];
            dataGridView2.Columns[0].HeaderText = languageData[9];
            dataGridView2.Columns[1].HeaderText = languageData[10];
            dataGridView2.Columns[2].HeaderText = languageData[11];
            dataGridView2.Columns[3].HeaderText = languageData[12];
            dataGridView2.Columns[4].HeaderText = languageData[13];
            dataGridView2.Columns[5].HeaderText = languageData[14];
            gbFunctions.Text = languageData[15];
            gbFindPersonByName.Text = languageData[16];
            gbFindPersonByEmail.Text = languageData[17];
        }

        private void btnFindPers_Click(object sender, EventArgs e)
        {
            try
            {
                //btnFindPers.Enabled = false;
                FNameInvalid = true;
                LNameInvalid = true;
                FNameInvalid = Customer.IsNameCorrect(txtboxFname.Text);
                LNameInvalid = Customer.IsNameCorrect(txtboxLname.Text);

                Customer customer = myDatabase.FindCustomerByName(txtboxFname.Text, txtboxLname.Text);
                dataGridView2.Rows.Clear();
                dataGridView2.Rows.Add(
                    customer.CustomerID,
                    customer.FirstName,
                    customer.LastName,
                    customer.Email,
                    customer.AccountBalance,
                    customer.LastChange);
            }
            catch (Exception ex)
            {
                if (FNameInvalid)
                {
                    epErrorMsg.SetError(txtboxFname, ex.Message);
                }
                else if (LNameInvalid)
                {
                    epErrorMsg.SetError(txtboxLname, ex.Message);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

                FNameInvalid = false;
                LNameInvalid = false;
            }

        }

        private void btnAdPers_Click(object sender, EventArgs e)
        {
            FormAddPerson dialog = new FormAddPerson();
            dialog.language = language;
            dialog.ShowDialog();
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            myDatabase = new CustomerDatabase();
            myDatabase.ReadPassword(passwordPath);
            myDatabase.readStoredData(path);

            foreach (Customer customer in myDatabase.Customers)
            {
                dataGridView2.Rows.Add(
                 customer.CustomerID,
                 customer.FirstName,
                 customer.LastName,
                 customer.Email,
                 customer.AccountBalance,
                 customer.LastChange);
            }
        }

        private void btnFindPersEmail_Click(object sender, EventArgs e)
        {
            try
            {
                Customer.CheckEmail(txtMail.Text);

                if (!myDatabase.IsEmailInDatabase(txtMail.Text))
                {
                    throw new ArgumentException("Customer Email not found");
                }

                Customer customer = myDatabase.FindCustomerByEmail(txtMail.Text);
                dataGridView2.Rows.Clear();
                dataGridView2.Rows.Add(
                    customer.CustomerID,
                    customer.FirstName,
                    customer.LastName,
                    customer.Email,
                    customer.AccountBalance,
                    customer.LastChange);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtMail.Clear();
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    myDatabase.changeName(txtboxLname.Text, txtMail.Text);
        //    myDatabase.StoreCSVData(path);
        //}

        private void btnChangeAttribut_Click(object sender, EventArgs e)
        {
            FormChangeAttr dialog = new FormChangeAttr();
            dialog.language = language;
            dialog.ShowDialog();
        }

        private void btnMoneyInOut_Click(object sender, EventArgs e)
        {
            FormMoneyInOut dialog = new FormMoneyInOut();
            dialog.language = language;
            dialog.ShowDialog();
        }

        public void LoadLanguageData(string language)
        {
            StreamReader sr = new StreamReader(@"..\..\..\Languages\" + this.Name + language + ".txt");
            //string text;

            while (!sr.EndOfStream)
            {
                for (int i = 0; i < languageData.Length; i++)
                {
                    languageData[i] = sr.ReadLine();
                }
            }
            sr.Close();
        }

        private void txtboxFname_Enter(object sender, EventArgs e)
        {
            txtboxFname.Clear();
            epErrorMsg.Clear();
        }

        private void txtboxLname_Enter(object sender, EventArgs e)
        {
            txtboxLname.Clear();
            epErrorMsg.Clear();
        }

        private void btnBackups_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(backupFolderPath))
            {
                myDatabase.StoreCSVData(backupFolderPath + "backup" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + ".crypt");
            }
            else
            {
                Directory.CreateDirectory(backupFolderPath);
                myDatabase.StoreCSVData(backupFolderPath + "backup" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + ".crypt");
            }
            
        }
    }
}
