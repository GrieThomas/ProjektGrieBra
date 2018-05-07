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
    public partial class FormChangeAttr : Form
    {
        CustomerDatabase myDatabase1;

        public FormChangeAttr()
        {
            InitializeComponent();
            myDatabase1 = new CustomerDatabase();
            myDatabase1.readStoredData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myDatabase1.changeName(txtboxLname.Text, txtMail.Text);
            myDatabase1.StoreCSVData();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myDatabase1.changeEmail(txtMail.Text, txtNewMail.Text);
            myDatabase1.StoreCSVData();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
