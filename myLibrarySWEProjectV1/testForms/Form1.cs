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

namespace testForms
{
    public partial class Form1 : Form
    {
        CustomerDatabase test = new CustomerDatabase();

        public Form1()
        {

            InitializeComponent();
            listBox1.DataSource = test;
        }
    }
}
