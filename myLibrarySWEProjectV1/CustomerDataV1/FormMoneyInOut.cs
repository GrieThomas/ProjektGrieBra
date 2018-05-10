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
    public partial class FormMoneyInOut : Form
    {
        CustomerDatabase myDatabase1;
        private string path = @"..\..\..\CustomerData.crypt";
        private string passwordPath = @"..\..\..\initFile.crypt";

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
            myDatabase1.FindCustomerByEmail(txtMail.Text).moneyOut(Convert.ToDouble(txtAmount.Text));

            txtNewAccountBalance.Text = myDatabase1.FindCustomerByEmail(txtMail.Text).AccountBalance.ToString();

            myDatabase1.StoreCSVData(path);
            txtAmount.Clear();

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
