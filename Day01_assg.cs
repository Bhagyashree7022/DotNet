using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDemo0
{
    internal class Day01_assg
    {
        public void tempConv() {

            int temp;
            string unit;
            Console.WriteLine("Enter temperature := ");
            temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter unit := ");
            unit =Console.ReadLine();
            if(unit[0] =='c')
            {
                double fahrenheit = (temp + 5 / 9) + 32;
                Console.WriteLine("temperature in Fahrenheit : " + fahrenheit);
            }
            else if (unit[0] == 'f')
            {
                double celcius = (temp - 32) * 5/9;
                Console.WriteLine("temperature in Celcius : " + celcius);

            }
            else {
                Console.WriteLine("Enter Valid unit c or f");

            }

        }

        public void bankSys() { 
         double initial_bal = 2000,amount;
            
            while (true)
            {
                Console.WriteLine("-*-*-*-*Menu --**--**--** \n0.Exit\n1.Check Balance \n2.Deposit \n3.Withdraw Amount ");
                Console.WriteLine("Enter your Choice := ");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch) {
                    case 1: Console.WriteLine(initial_bal);
                        break;
                    case 2: Console.WriteLine("Enter amount want to deposit := ");
                            amount = Convert.ToDouble(Console.ReadLine());
                            initial_bal += amount;
                        break;
                    case 3:Console.WriteLine("Enter amount want to withdraw := ");
                           amount = Convert.ToDouble(Console.ReadLine());
                        if (amount < initial_bal)
                        { initial_bal -= amount;
                            Console.WriteLine("remaining balance is := "+initial_bal);
                        }
                        else { Console.WriteLine("Insufficient Balance "); }
                            break;
                    case 0:Console.WriteLine("Exit");
                        return ;
                    default:Console.WriteLine("Invalid Choice ! try Again ");
                        break;
                }
            }
        }

        public void bill() {
            int quantity,bill=0,ch;
            while (true)
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1. Burger     - Rs50");
                Console.WriteLine("2. Pizza      - Rs250");
                Console.WriteLine("3. Vadapav    - Rs30");
                Console.WriteLine("4. Idli       - Rs10");
                Console.WriteLine("5. Chinese    - Rs50");
                Console.WriteLine("6. Generate Bill");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your Choice: ");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Burger quantity := ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        bill += quantity * 50;
                        break;
                    case 2:
                        Console.WriteLine("Enter Pizza  quantity := ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        bill += quantity * 250; 
                        break;
                    case 3:
                        Console.WriteLine("Enter Vadapv quantity := ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        bill += quantity * 30;
                        break;
                    case 4:
                        Console.WriteLine("Enter Idli quantity := ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        bill += quantity * 10;
                        break;
                    case 5:
                        Console.WriteLine("Enter Chineze  quantity := ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        bill += quantity * 50;
                        break;
                    case 6:
                        Console.WriteLine("Total bill Generated := Rs"+bill);
                        break;
                    case 0:
                        Console.WriteLine("Thankyoy ! Visit Again");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice ! try Again ");
                        break;
                }
            }
           
        }

    }
}
