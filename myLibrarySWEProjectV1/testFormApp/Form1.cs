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

namespace testFormApp
{
    public partial class Form1 : Form
    {
        CustomerDatabase testBase = new CustomerDatabase();
        public Form1()
        {

            InitializeComponent();

            
        }
    }
}
