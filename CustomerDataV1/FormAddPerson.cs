using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerDataV1
{
    public partial class FormAddPerson : Form
    {
        CustomerDatabase myDatabase1;

        public FormAddPerson()
        {
            InitializeComponent();
            myDatabase1 = new CustomerDatabase();
            myDatabase1.readStoredData();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            myDatabase1.AddCustomer(txtboxFname.Text, txtboxLname.Text, txtMail.Text);
            myDatabase1.StoreCSVData();
            this.Close();
            
        }
    }
}
