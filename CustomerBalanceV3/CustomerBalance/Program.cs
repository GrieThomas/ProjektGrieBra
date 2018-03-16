using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "thomas.griesner@gmx.wasd";
            

            Console.WriteLine("Der Check ergab:" + CheckEmail(email));


        }

        public static bool CheckEmail(string mail)
        {

            int countTest1 = 0;
            int countTest2 = 0;
            int countTest3 = 0;
            //bool isNumber = false;
            
             
            for (int i = 0; i < mail.Length; i++)
            {
                    Console.Write(Convert.ToInt32(mail[i]));
                    Console.WriteLine(mail[i]);

                // Test1:must contain exactly one @ and Test2:at least one . after the @
                    if (Convert.ToInt32(mail[i])==64)
                    {
                        countTest1++;

                    }
                    if (countTest1 == 1 && mail[i].Equals('.'))
                    {
                        countTest2++;
                    }

                // Test3:after final . must be 2-4 letters
                
                if (mail[mail.Length - 1-i].Equals('.')&&countTest3==0)
                {
                    countTest3 = i;
                    for (int j =mail.Length-1-i ; j < mail.Length; j++)
                    {
                        if (Char.IsNumber(mail[j]))
                        {
                            return false;
                        }
                    }

                }

                
            }
            // Test4:There must be at least one character before the @
            for (int i = 0; i < mail.Length; i++)
            {
                if (mail[i].Equals('@') && i < 1)
                {
                    return false;
                }
            }

            // Check result of Test 1,2,3
            if (countTest1!=1 || countTest2<1 || (countTest3<=1||countTest3>=5))
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
