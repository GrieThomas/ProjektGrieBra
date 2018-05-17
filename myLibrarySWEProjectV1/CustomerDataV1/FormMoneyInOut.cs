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
using System.Runtime.CompilerServices;

namespace CustomerDataV1
{
    public partial class FormMoneyInOut : Form
    {
        CustomerDatabase myDatabase1;
        private string path = @"..\..\..\CustomerData.crypt";
        private string passwordPath = @"..\..\..\init\passwordFile.crypt";
        public string language;
        public string[] languageData = new string[30];

        //private string path = @"CustomerData.crypt";
        //private string passwordPath = @"init\passwordFile.crypt";
        //private string selLangPath = @"init\languageFile.lng";
        //private string initdir = @"init";

        public FormMoneyInOut()
        {
            InitializeComponent();
            myDatabase1 = new CustomerDatabase();
            myDatabase1.ReadPassword(passwordPath);
            myDatabase1.readStoredData(path);
        }

        private void btnMoneyIn_Click(object sender, EventArgs e)
        {
            myDatabase1.FindCustomerByEmail(txtMail.Text).moneyIn(Convert.ToDouble(txtAmount.Text));
            myDatabase1.StoreCSVData(path);

            txtNewAccountBalance.Text = myDatabase1.FindCustomerByEmail(txtMail.Text).AccountBalance.ToString();
            txtAmount.Clear();
        }

        private void btnMoneyOut_Click(object sender, EventArgs e)
        {
            try
            {
                myDatabase1.FindCustomerByEmail(txtMail.Text).moneyOut(Convert.ToDouble(txtAmount.Text));
                txtNewAccountBalance.Text = myDatabase1.FindCustomerByEmail(txtMail.Text).AccountBalance.ToString();

                myDatabase1.StoreCSVData(path);
                txtAmount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMoneyInOut_Load(object sender, EventArgs e)
        {
            try
            {
                LoadLanguageData(language);

                this.Text = languageData[0];
                lblEmail.Text = languageData[1];
                lblAmount.Text = languageData[2];
                btnMoneyIn.Text = languageData[3];
                btnMoneyOut.Text = languageData[4];
                lblNewBal.Text = languageData[5];
                btnDone.Text = languageData[6];
                btnAbort.Text = languageData[7];
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }
        public void LoadLanguageData(string language)
        {
            try
            {
                StreamReader sr = new StreamReader(@"..\Languages\" + this.Name + language + ".txt");
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void btnGetBalance_Click(object sender, EventArgs e)
        {
            try
            {
                epErrorMsg.Clear();
                tbxBalance.Text = myDatabase1.FindCustomerByEmail(txtMail.Text).AccountBalance.ToString();
                groupBox2.Enabled = groupBox3.Enabled = true;
            }
            catch (Exception ex)
            {
                epErrorMsg.SetError(txtMail, ex.Message);
            }
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = groupBox3.Enabled = false;
        }

        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            double amount;
            txtAmount.BackColor = DefaultBackColor;

            btnMoneyIn.Enabled = true;
            btnMoneyOut.Enabled = true;
            epErrorMsg.Clear();

            try
            {
                if (!Double.TryParse(txtAmount.Text, out amount))
                {
                    btnMoneyIn.Enabled = false;
                    btnMoneyOut.Enabled = false;

                    throw new ArgumentException("Entry not valid");
                }
            }
            catch (Exception ex)
            {
                epErrorMsg.SetError(txtAmount, ex.Message);
            }

        }
    }
}
