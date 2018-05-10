using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace myLibrarySWEProject
{
    public class CustomerDatabase
    {
        private List<Customer> customers = new List<Customer>();
        private int count;

        private string password = "password";
        private string encryptinionKey = "1n3o4b4gnjke";

        //private Customer dummyCustomer = new Customer(-1, "dummy", "dummy","dummy");

        //public void Customer()
        //{
        //    //customers 
        //    //count = 0;
        //}

        public List<Customer> Customers
        {
            get { return customers; }
            private set { customers = value; }
        }

        public int Count
        {
            get { return count; }
            private set { count = value; }
        }

        public string Password // Get eventuell auf private setzen
        {
             get { return password; }
            set { password = value; }
        }
        

        public int AddCustomer(string firstname, string lastname, string email)
        {
            for (int i = 1; i <= Count + 1; i++)
            {
                if (this.FindCustomerByID(i) == null)
                {
                    customers.Add(new Customer(i, firstname, lastname, email));
                    count++;
                    return 1; //Return 1 if successful
                }
            }
            return -1;//Return 1 if not successful
        }

        public Customer FindCustomerByName(string firstName, string lastName)
        {

            //Customer actCustomer = customers.First();

            //while (actCustomer.FirstName != firstName && actCustomer.LastName != lastName && actCustomer == customers.Last())
            //{
            //    counter++;
            //}
            foreach (Customer actCustomer in customers)
            {
                if (actCustomer.FirstName == firstName && actCustomer.LastName == lastName)
                {
                    return actCustomer;
                }
            }
            return null;

        }

        public Customer FindCustomerByEmail(string Email)
        {
            foreach (Customer actCustomer in customers)
            {
                if (actCustomer.Email == Email)
                {
                    return actCustomer;
                }
            }
            return null;

        }

        public Customer FindCustomerByID(int customerID)
        {
            if (this.Count == 0)
            {
                return null;
            }

            foreach (Customer actCustomer in customers)
            {
                if (actCustomer.CustomerID == customerID)
                {
                    return actCustomer;
                }
            }
            return null;
        }

        public void changeName(string newLastName, string email)
        {
            FindCustomerByEmail(email).changeLastName(newLastName);
        }

        public bool changeEmail(string email, string newEmail)
        {
            if (FindCustomerByEmail(newEmail) == null && FindCustomerByEmail(email) != null)// neue darf nicht vorhanden sein, alte muss vorhanden sein
            {
                FindCustomerByEmail(email).changeEmail(newEmail);
                return true;
            }
            return false;
        }

        public void readStoredData(string path)
        {
            //path = @"..\..\..\CustomerData.crypt";
            StreamReader sr = new StreamReader(path);
            string[] data;

            while (!sr.EndOfStream)
            {
                data = sr.ReadLine().Split(';');

                //foreach (var var in data)
                //{
                //    var = Decrypt(var, password);
                //}

                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = Decrypt(data[i], password);
                    Console.WriteLine(data[i]);
                }

                if (data.Length == 6)
                {
                    if (this.FindCustomerByID(Convert.ToInt32(data[0])) == null)//Abfrage ob Customer bereits vorhanden
                    {
                        customers.Add(new Customer(Convert.ToInt32(data[0]), data[1], data[2], data[3], Convert.ToDouble(data[4]), Convert.ToDateTime(data[5])));
                        count++;
                    }
                }
            }
            sr.Close();
        }

        //public List<Customer> getCustomerDatabase()
        //{
        //    return 
        //}

        public void ReadCSVData(string path)
        {
            //Check if File is existent 
            //path = @"..\..\..\CustomerData.crypt";
            StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();
        }

        //public void StoreCSVData()
        //{

        //    StreamWriter sw = new StreamWriter(@"..\..\..\CustomerData.csv");
        //    sw.WriteLine("Customers");

        //    foreach (Customer actCustomer in customers)
        //    {
        //        sw.WriteLine(Convert.ToString(actCustomer.CustomerID) + ';' + actCustomer.FirstName + ';' + actCustomer.LastName + ';' + actCustomer.Email + ';' + actCustomer.AccountBalance + ';' + actCustomer.LastChange);
        //    }

        //    sw.Close();
        //}

        public void StoreCSVData(string path)
        {

            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("ID;FirstName;LastName;E-Mail;Time");

            foreach (Customer actCustomer in customers)
            {
                sw.WriteLine(Convert.ToString(Encrypt(Convert.ToString(actCustomer.CustomerID),password)) 
                    + ';' + 
                    Encrypt(actCustomer.FirstName,password) 
                    + ';' + 
                    Encrypt(actCustomer.LastName,password) 
                    + ';' + 
                    Encrypt(actCustomer.Email,password) 
                    + ';' + 
                    Encrypt(Convert.ToString(actCustomer.AccountBalance),password) 
                    + ';' + 
                    Encrypt(Convert.ToString(actCustomer.LastChange),password));
            }

            sw.Close();
        }

        public static string Encrypt(string clearText, string password)
        {
            string EncryptionKey = password;
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        public static string Decrypt(string cipherText, string password)
        {
            string EncryptionKey = password;
            cipherText = cipherText.Replace(" ", "+");
            try
            {
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return cipherText;
        }


        public void ChangePassword(string Initpath,string dataPath, string newPassword)
        {
            password = newPassword; // schreiben des neuen Passworts
            StreamWriter sw = new StreamWriter(Initpath);
            sw.WriteLine(Encrypt(newPassword,encryptinionKey)); //Ablegen des neuen Passworts
            sw.Close();
            StoreCSVData(dataPath);//Daten mit neuem Passwort erneut ablegen
        }

        public void ReadPassword(string path)
        {
            StreamReader sr = new StreamReader(path);
            password = Decrypt(sr.ReadLine(), encryptinionKey);//Lesen des Passworts aus dem Init File
            sr.Close();
        }
    }
}
