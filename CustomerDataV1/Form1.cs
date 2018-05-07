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
    
    public partial class Form1 : Form
    {
        private CustomerDatabase myDatabase;
        
        
        public Form1()
        {
            
            InitializeComponent();
            myDatabase = new CustomerDatabase();
            myDatabase.readStoredData();
            comboBox1.Items.Add("English");
            comboBox1.Items.Add("German");
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnpsw_Click(object sender, EventArgs e)
        {
            if (txtboxPsw.Text.Equals("1"))
            {
                

                //switch to Form Menu
                FormMenu dialog = new FormMenu();
                dialog.ShowDialog();
                txtboxPsw.Clear();

                
            }
        }

        
    }
}
