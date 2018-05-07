using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomerDataV1
{
    class Customer
    {
        private int customerID;
        private string firstName;
        private string lastName;
        private string email;
        private double accountBalance;
        private DateTime lastChange;

        public Customer(int customerID, string firstName, string lastName, string email)
        {
            this.customerID = customerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;

            accountBalance = 0.0;
            lastChange = DateTime.Now;
        }

        public Customer(int customerID, string firstName, string lastName, string email, double accountBalance,DateTime lastChange )
        {
            this.customerID = customerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.accountBalance = accountBalance;
            this.lastChange = lastChange;

        }

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

        public bool moneyIn(double val)
        {
            AccountBalance += val;
            LastChange = DateTime.Now;
            return true;
        }

        public bool moneyOut(double val)
        {
            if (AccountBalance >= val)
            {
                AccountBalance -= val;
                LastChange = DateTime.Now;
                return true;
            }
            return false;

        }

        public void changeLastName(string newLastName)
        {
            LastName = newLastName;
        }

        public void changeEmail(string newEmail)
        {
            Email = newEmail;
        }


        public override string ToString()
        {
            return this.CustomerID + " " + this.FirstName + " " + this.lastName + " " + this.email;
        }

        public static bool CheckEmail(string mail)
        {
            int countTest1 = 0;
            int countTest2 = 0;
            int countTest3 = 0;
            int positionOfAt = 0;

            for (int i = 0; i < mail.Length; i++)
            {
                Console.Write(Convert.ToInt32(mail[i]));
                Console.WriteLine(mail[i]);

                // Test1:must contain exactly one @ and Test2:at least one . after the @
                if (Convert.ToInt32(mail[i]) == 64)
                {
                    countTest1++;
                    positionOfAt = i;
                }
                if (countTest1 == 1 && mail[i].Equals('.'))
                {
                    countTest2++;
                }

                // Test3:after final . must be 2-4 letters

                if (mail[mail.Length - 1 - i].Equals('.') && countTest3 == 0)
                {
                    countTest3 = i;
                    for (int j = mail.Length - 1 - i; j < mail.Length; j++)
                    {
                        if (Char.IsNumber(mail[j]))
                        {
                            return false;
                        }
                    }

                }

            }
            ///////////////////////////////Auswerten der Testergebnisse 

            // Test4:There must be at least one character before the @
            for (int i = 0; i < mail.Length; i++)
            {
                if (mail[i].Equals('@') && i < 1)
                {
                    return false;
                }
            }
            // Test 5: Check for invalid characters
            if (!Regex.IsMatch(mail, @"^[a-zA-Z0-9.#%&'*+/=?^`{|}!@~$_-]+$"))
            {
                return false;
            }

            //Test 6: There must not be a.at the start, end or just before/ after the @
            if (mail[0].Equals('.') || mail[mail.Length - 1].Equals('.') || mail[positionOfAt - 1].Equals('.') || mail[positionOfAt + 1].Equals('.'))
            {
                return false;
            }

            // Check result of Test 1,2,3
            if (countTest1 != 1 || countTest2 < 1 || (countTest3 <= 1 || countTest3 >= 5))
            {
                return false;
            }
            else
            {
                return true;
            }

            return true;
        }
    }
}
