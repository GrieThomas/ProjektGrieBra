﻿using System;
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
    public partial class FormChangeAttr : Form
    {
        CustomerDatabase myDatabase1;
        private string path = @"..\..\..\CustomerData.crypt";
        private string passwordPath = @"..\..\..\initFile.crypt";
        public string language;
        public string[] languageData = new string[30];

        public FormChangeAttr()
        {
            InitializeComponent();
            myDatabase1 = new CustomerDatabase();
            myDatabase1.ReadPassword(passwordPath);
            myDatabase1.readStoredData(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myDatabase1.changeName(txtboxLname.Text, txtMail.Text);
            myDatabase1.StoreCSVData(path);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myDatabase1.changeEmail(txtMail.Text, txtNewMail.Text);
            myDatabase1.StoreCSVData(path);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormChangeAttr_Load(object sender, EventArgs e)
        {
            LoadLanguageData(language);
            this.Text = languageData[0];
            gpChLstName.Text = languageData[1];
            lblLname.Text = languageData[2];
            lblEmail.Text = languageData[3];
            btnChange1.Text = languageData[4];
            gbChEmail.Text = languageData[5];
            lblEmail2.Text = languageData[6];
            lblNewEmail.Text = languageData[7];
            btnChange2.Text = languageData[8];
            btnDone.Text = languageData[9];
            btnAbort.Text = languageData[10];

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
    }
}
