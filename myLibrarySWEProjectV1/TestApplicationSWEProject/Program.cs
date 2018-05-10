using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using myLibrarySWEProject;

namespace TestApplicationSWEProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hallo 2
            
            //Customer c1 = new Customer(1,"Sepp", "Forcher", "s.f@blasmusi.at");

            CustomerDatabase testDatabase = new CustomerDatabase();

            //Console.WriteLine(c1.FirstName);
            //Console.WriteLine(c1.AccountBalance);
            //Console.WriteLine(c1.moneyIn(1000));
            //Console.WriteLine(c1.AccountBalance);
            //Console.WriteLine(c1.moneyOut(10000));
            //Console.WriteLine(c1.moneyOut(100));
            //Console.WriteLine(c1.AccountBalance);


            Console.WriteLine(testDatabase.AddCustomer("Hansi", "Hinterseer", "hansi1@edelweiss.at"));
            testDatabase.AddCustomer("Hansi", "Hinterseer", "hansi2@edelweiss.at");
            testDatabase.AddCustomer("Hansi", "Hinterseer", "hansi3@edelweiss.at");

            foreach (Customer var in testDatabase.Customers)
            {
                Console.WriteLine(var.CustomerID + " " + var.FirstName + " " + var.LastName + " " + var.Email);
            }
            Console.WriteLine(testDatabase.Count);

            testDatabase.changeEmail("hansi2@edelweiss.at", "hansi21@edelweiss.at");

            foreach (Customer var in testDatabase.Customers)
            {
                Console.WriteLine(var.CustomerID + " " + var.FirstName + " " + var.LastName + " " + var.Email);
            }
            testDatabase.changeEmail("hansi2@edelweiss.at", "hansi1@edelweiss.at");

            foreach (Customer var in testDatabase.Customers)
            {
                Console.WriteLine(var.CustomerID + " " + var.FirstName + " " + var.LastName + " " + var.Email);
            }

            //Console.WriteLine(testDatabase.Customers.Contains(new Customer("Hansi", "Hinterseer", "hansi@edelweiss.at")));
            //Console.WriteLine(testDatabase.Customers.Contains(c1));
            //Console.WriteLine(testDatabase.FindCustomer("Hansi","Hinterseer").ToString());

          

            //////////////////////////////////////////////////////////
            ///  Testing input and Output
            /// /////////////////////////////////////////////////////
            


            //testDatabase.StoreCSVData(@"..\..\..\CustomerData.crypt");
            //testDatabase.readStoredData(@"..\..\..\CustomerData.crypt");
            //testDatabase.StoreCSVData(@"..\..\..\CustomerData.crypt");
            //testDatabase.ReadCSVData(@"..\..\..\CustomerData.crypt");

            //////////////////////////////////////////////////////////
            ///  Testing password change
            /// /////////////////////////////////////////////////////


            //testDatabase.StoreCSVData(@"..\..\..\CustomerData.crypt");
            //testDatabase.readStoredData(@"..\..\..\CustomerData.crypt");
            //testDatabase.StoreCSVData(@"..\..\..\CustomerData.crypt");
            ////testDatabase.ReadCSVData(@"..\..\..\CustomerData.crypt");

            //Console.WriteLine("Password:  " + testDatabase.Password);

            //testDatabase.ChangePassword(@"..\..\..\initFile.crypt", @"..\..\..\CustomerData.crypt", "safb3f323r");
            //testDatabase.ReadPassword(@"..\..\..\initFile.crypt");

            //Console.WriteLine("Password:  " + testDatabase.Password);
            //testDatabase.readStoredData(@"..\..\..\CustomerData.crypt");

            // erfolgreich 


            //////////////////////////////////////////////////////////
            ///  Testing password change
            /// /////////////////////////////////////////////////////
            /// 
            /// Verschlüsselt mit irgendeinem Passwort
            /// 
            /// Kann nicht lesen da verschlüsselt

            

            //testDatabase.readStoredData(@"..\..\..\CustomerData.crypt");
            //testDatabase.StoreCSVData(@"..\..\..\CustomerData.crypt");
            ////testDatabase.ReadCSVData(@"..\..\..\CustomerData.crypt");

            //Console.WriteLine("Password:  " + testDatabase.Password);


            //////////////////////////////////////////////////////////
            ///  Testing password change
            /// /////////////////////////////////////////////////////
            /// 
            /// Verschlüsselt mit irgendeinem Passwort
            /// 
            /// Kann lesen, holt sich Passwort aus init File
            /// 
            /// 
            testDatabase.ReadPassword(@"..\..\..\initFile.crypt");

            testDatabase.readStoredData(@"..\..\..\CustomerData.crypt");
            testDatabase.StoreCSVData(@"..\..\..\CustomerData.crypt");
            //testDatabase.ReadCSVData(@"..\..\..\CustomerData.crypt");

            Console.WriteLine("Password:  " + testDatabase.Password);

           // Hallo 
            // Hallo 3
        }
    }
}
