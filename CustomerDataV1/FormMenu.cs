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

namespace CustomerDataV1
{
    public partial class FormMenu : Form
    {
        private CustomerDatabase myDatabase;

        public FormMenu()
        {
            InitializeComponent();
            myDatabase = new CustomerDatabase();
            myDatabase.readStoredData();

            dataGridView2.Columns.Add("1", "Customer ID");
            dataGridView2.Columns.Add("2", "First Name");
            dataGridView2.Columns.Add("3", "Last Name");
            dataGridView2.Columns.Add("4", "E-Mail");
            dataGridView2.Columns.Add("5", "Account balance");
            dataGridView2.Columns.Add("6", "Last change");

            
        }

        private void btnFindPers_Click(object sender, EventArgs e)
        {
            Customer customer = myDatabase.FindCustomerByName(txtboxFname.Text, txtboxLname.Text);
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(
                customer.CustomerID, customer.FirstName, customer.LastName, customer.Email, customer.AccountBalance, customer.LastChange
            );
            
        }

        private void btnAdPers_Click(object sender, EventArgs e)
        {
            FormAddPerson dialog = new FormAddPerson();
           
            dialog.ShowDialog();

        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            //string colname = "1";
            //string header = "Header";

            dataGridView2.Rows.Clear();
            myDatabase=new CustomerDatabase();
            myDatabase.readStoredData();
            foreach (Customer customer in myDatabase.Customers)
            {
                
                this.dataGridView2.Rows.Add(
                
                    customer.CustomerID, customer.FirstName, customer.LastName, customer.Email,customer.AccountBalance,customer.LastChange

                );

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFindPersEmail_Click(object sender, EventArgs e)
        {
            Customer customer = myDatabase.FindCustomerByEmail(txtMail.Text);
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(
                customer.CustomerID, customer.FirstName, customer.LastName, customer.Email, customer.AccountBalance, customer.LastChange
            );

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myDatabase.changeName(txtboxLname.Text,txtMail.Text);
            myDatabase.StoreCSVData();
        }

        private void btnChangeAttribut_Click(object sender, EventArgs e)
        {
            FormChangeAttr dialog = new FormChangeAttr();

            dialog.ShowDialog();
        }

        private void btnMoneyInOut_Click(object sender, EventArgs e)
        {
            FormMoneyInOut dialog = new FormMoneyInOut();

            dialog.ShowDialog();
        }
        
    }
}
