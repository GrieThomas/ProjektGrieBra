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

    public partial class Form1 : Form
    {
        private CustomerDatabase myDatabase;
        private string path = @"..\..\..\CustomerData.crypt";
        private string passwordPath = @"..\..\..\initFile.crypt";
        //public string[] languageData;
        //public List<string> languageData = new List<string>();
        
        public string[] languageData = new string[3];
        

        

        // string password;

        public Form1()
        {

            InitializeComponent();
            myDatabase = new CustomerDatabase();
            myDatabase.ReadPassword(passwordPath);
            myDatabase.readStoredData(path);

            comboBox1.Items.Add("English");
            comboBox1.Items.Add("Deutsch");
            comboBox1.SelectedItem = "English";
            this.Text = "Start";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            LoadLanguageData(comboBox1.SelectedItem.ToString());
            btnpsw.Text = languageData[0];
            lblPsw.Text = languageData[1];
            lblLang.Text = languageData[2];
        }

        private void btnpsw_Click(object sender, EventArgs e)
        {
            if (txtboxPsw.Text.Equals("1"))
            {


                //switch to Form Menu
                FormMenu dialog = new FormMenu();
                dialog.language = comboBox1.SelectedItem.ToString();
                dialog.ShowDialog();
  
                txtboxPsw.Clear();


            }
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

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadLanguageData(comboBox1.SelectedItem.ToString());
            btnpsw.Text = languageData[0];
            lblPsw.Text = languageData[1];
            lblLang.Text = languageData[2];
        }
    }
}
