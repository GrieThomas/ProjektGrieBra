using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDataV1
{
    class CustomerDatabase
    {
        private List<Customer> customers = new List<Customer>();
        private int count;
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

        public void readStoredData()
        {
            string path = @"..\..\..\CustomerData.csv";
            StreamReader sr = new StreamReader(path);
            string[] data;

            while (!sr.EndOfStream)
            {
                data = sr.ReadLine().Split(';');

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
            path = @"..\..\..\CustomerData.csv";
            StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();
        }

        public void StoreCSVData()
        {

            StreamWriter sw = new StreamWriter(@"..\..\..\CustomerData.csv");
            sw.WriteLine("ID;FirstName;LastName;E-Mail;Time");

            foreach (Customer actCustomer in customers)
            {
                sw.WriteLine(Convert.ToString(actCustomer.CustomerID) + ';' + actCustomer.FirstName + ';' + actCustomer.LastName + ';' + actCustomer.Email + ';' + actCustomer.AccountBalance + ';' + actCustomer.LastChange);
            }

            sw.Close();
        }
    }
}
