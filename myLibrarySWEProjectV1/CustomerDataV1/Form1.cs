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
        private string path = @"..\CustomerData.crypt";
        private string passwordPath = @"..\Init\passwordFile.crypt";
        private string selLangPath = @"..\Init\languageFile.lng";
        private string initdir = @"..\Init";
        private string password;

        //private string path = @"CustomerData.crypt";
        //private string passwordPath = @"init\passwordFile.crypt";
        //private string selLangPath = @"init\languageFile.lng";
        //private string initdir = @"init";


        private string selLang = "English";
        //public string[] languageData;
        //public List<string> languageData = new List<string>();

        public string[] languageData = new string[3];

        public Form1()
        {

            InitializeComponent();
            myDatabase = new CustomerDatabase();

            if (!Directory.Exists(initdir))
            {
                Directory.CreateDirectory(initdir);
            }

            if (File.Exists(selLangPath))
            {
                StreamReader sr = new StreamReader(selLangPath);
                selLang = sr.ReadLine();
                sr.Close();
            }


            myDatabase.ReadPassword(passwordPath);
            myDatabase.readStoredData(path);



            comboBox1.Items.Add("English");
            comboBox1.Items.Add("Deutsch");
            comboBox1.SelectedItem = selLang;
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
            myDatabase.ReadPassword(passwordPath);
            try
            {
                if (txtboxPsw.Text.Equals(myDatabase.Password))
                {
                    //switch to Form Menu
                    FormMenu dialog = new FormMenu();
                    dialog.language = comboBox1.SelectedItem.ToString();
                    dialog.passwordPath = passwordPath;
                    dialog.ShowDialog();
                    txtboxPsw.Clear();
                }
                else
                {
                    throw new ArgumentException("Wrong password");
                }
            }
            catch (Exception ex)
            {
                epErrorMsg.SetError(txtboxPsw, ex.Message);
                //e.Cancel = false;
            }
        }

        private void LoadLanguageData(string language)
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

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            StreamWriter sw = new StreamWriter(selLangPath);
            sw.WriteLine(comboBox1.SelectedItem.ToString());
            sw.Close();

            LoadLanguageData(comboBox1.SelectedItem.ToString());
            btnpsw.Text = languageData[0];
            lblPsw.Text = languageData[1];
            lblLang.Text = languageData[2];


        }

        private void txtboxPsw_Enter(object sender, EventArgs e)
        {
            txtboxPsw.Clear();
            //txtboxPsw.Text = "Passwort"; // Debugging
            epErrorMsg.Clear();
        }

        private void btnOpt_Click(object sender, EventArgs e)
        {
            FormOptions dialog = new FormOptions();
            password = dialog.password;
            dialog.Show();

        }




    }
}
