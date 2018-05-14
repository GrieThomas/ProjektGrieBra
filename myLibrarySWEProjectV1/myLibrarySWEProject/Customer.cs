using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace myLibrarySWEProject
{
    public class Customer
    {

        #region Members

        private int customerID;
        private string firstName;
        private string lastName;
        private string email;
        private double accountBalance;
        private DateTime lastChange;

        #endregion

        #region Konstruktoren

        public Customer(int customerID, string firstName, string lastName, string email)
        {
            this.customerID = customerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;

            accountBalance = 0.0;
            lastChange = DateTime.Now;
        }

        public Customer(int customerID, string firstName, string lastName, string email, double accountBalance, DateTime lastChange)
        {
            this.customerID = customerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.accountBalance = accountBalance;
            this.lastChange = lastChange;
        }

        #endregion

        #region Get Set

        public int CustomerID
        {
            get { return customerID; }
            private set { customerID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            private set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            private set { email = value; }
        }

        public double AccountBalance
        {
            get { return accountBalance; }
            private set { accountBalance = value; }
        }

        public DateTime LastChange
        {
            get { return lastChange; }
            private set { lastChange = value; }
        }

        # endregion

        # region Methoden

        public void moneyIn(double val)
        {
            AccountBalance += val;
            LastChange = DateTime.Now;
        }

        public void moneyOut(double val)
        {
            if (AccountBalance >= val)
            {
                AccountBalance -= val;
                LastChange = DateTime.Now;
            }
            else
            {
                throw new ArgumentException("Not enough money available");
            }
            

        }

        public void changeLastName(string newLastName)
        {
            LastName = newLastName;
        }

        public void changeEmail(string newEmail)
        {
            Email = newEmail;
        }

        #endregion

        #region overide methoden

        public override string ToString()
        {
            return this.CustomerID + " " + this.FirstName + " " + this.lastName + " " + this.email;
        }

        #endregion

        #region Statische Methoden

        public static bool CheckEmail(string mail)
        {
            int countTest1 = 0;
            int countTest2 = 0;
            int countTest3 = 0;
            int positionOfAt = 0;
          


            // Test0: String should not be empty
            if (mail.Equals(String.Empty))
            {
                throw new ArgumentException("Empty String");
            }

            for (int i = 0; i < mail.Length; i++)
            {
                Console.Write(Convert.ToInt32(mail[i]));
                Console.WriteLine(mail[i]);

                // Test1: must contain exactly one @ 
                if (Convert.ToInt32(mail[i]) == 64)
                {
                    countTest1++;
                    positionOfAt = i;
                }
                // Test2: at least one . after the @

                if (countTest1 == 1 && mail[i].Equals('.'))
                {
                    countTest2++;
                }

                // Test3:after final . must be 2-4 letters (Domain must be 2-4 letters)

                if (mail[mail.Length - 1 - i].Equals('.') && countTest3 == 0)
                {
                    countTest3 = i;
                    for (int j = mail.Length - 1 - i; j < mail.Length; j++)
                    {
                        if (Char.IsNumber(mail[j]))
                        {
                            
                            throw new ArgumentException("Domain must be 2-4 letters");
                        }
                    }
                }
            }
            //*************************
            // Evaluation of test 1 - 3
            //*************************
            if (countTest1 != 1)
            {
                throw new ArgumentException(" Address must contain exactly one @");
            }
            if (countTest2 < 1)
            {
                throw new ArgumentException("Address must contain at least one . after the @");
            }
            if (countTest3 <= 1 || countTest3 >= 5)
            {
                throw new ArgumentException("Domain must be 2-4 letters");
            }


            // Test4:There must be at least one character before the @

            for (int i = 0; i < mail.Length; i++)
            {
                if (mail[i].Equals('@') && i < 1)
                {
                    throw new ArgumentException("There must be at least one character before the @");
                }
            }

            // Test 5: Check for invalid characters
            //if (!Regex.IsMatch(mail, @"^[a-zA-Z0-9.#%&'*+/=?^`{|}!@~$_-]+$"))
            //{
            //    return false;
            //}

            string validSigns = "abcdefghijklmnopqrstuvwxyz" +
                                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                                "123456789" +
                                ".!#$%&'*+-/=?^_`{|}~_@";

            for (int i = 0; i < mail.Length; i++)
            {
                if (!validSigns.Contains(mail[i]))
                {
                    throw new ArgumentException("Invalid Characters used");
                }
            }

            //for (int j = 0; j < validSigns.Length; j++)
            //{
            //    for (int i = 0; i < mail.Length; i++)
            //    {
            //        if (mail[i].Equals(validSigns[j]))
            //        {
            //            throw new ArgumentException("Invalid Characters used");
            //        }

            //    }
            //}


            //Test 6: There must not be a.at the start, end or just before/ after the @
            if (mail[0].Equals('.') 
                || 
                mail[mail.Length - 1].Equals('.')
                || 
                mail[positionOfAt - 1].Equals('.') 
                || 
                mail[positionOfAt + 1].Equals('.'))
            {
                throw new ArgumentException("There must not be a.at the start, end or just before/ after the @");
            }

            //// Check result of Test 1,2,3,5

            //if (countTest1 != 1)
            //{
            //    throw new ArgumentException("Invalid Characters used");
            //}
            //if (countTest2 < 1)
            //{
            //    throw new ArgumentException("Invalid Characters used");
            //}
            //if (countTest3 <= 1)
            //{
            //    throw new ArgumentException("Invalid Characters used");
            //}
            //if (countTest3 >= 5)
            //{
            //    throw new ArgumentException("Invalid Characters used");
            //}

            return true;
        }

        public static bool IsNameCorrect(string name)
        {
            int test;
            int count = 0;
            bool valid = false;

            if (name.Equals(String.Empty))
            {
                throw new ArgumentException("Eingabe erforderlich");
            }


            for (int i = 0; i < name.Length; i++)
            {
                if (Int32.TryParse(Convert.ToString(name[i]), out test))
                {
                    throw new ArgumentException("Name darf keine Zahl enthalten");
                }
            }
            if (!Char.IsUpper(name[0]))
            {
                throw new ArgumentException("Name muss mit Großbuchstaben beginnen");
            }
            for (int i = 1; i < name.Length; i++)
            {
                if (Char.IsLower(name[i]))
                {
                    count++;
                }
            }
            if (count < 2)
            {
                throw new ArgumentException("Name muss min 2 Kleinbuchstaben enthalten");
            }
            return valid;
        }

        #endregion
    }
}
