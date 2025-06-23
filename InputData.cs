using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace myDemo0
{
    internal class InputData
    {
        public void method1() { 
            int age;
            String name;
            Console.WriteLine("Enter Name := ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Age := ");
            age= Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("name :" + name);
            Console.WriteLine("age : " + age);

        }

        public void method2()
        {

            Console.Write("Enter number :");
            int n =Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else {
                Console.WriteLine("Odd");

            }
        }

        public void method3() {

            Console.WriteLine("Enter character : ");
            char alpha = Convert.ToChar(Console.ReadLine());
            switch (alpha) {
                case 'a': Console.WriteLine("a");break;
                case 'e': Console.WriteLine("e"); break;
                case 'i': Console.WriteLine("e"); break;
                case 'o': Console.WriteLine("e"); break;
                case 'u': Console.WriteLine("e"); break;

            }

        }
        public void method4() {

            int a;
            Console.WriteLine("Enter number :");
           a = Convert.ToInt32( Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine(" Positive Number .");
            }
            else {
                Console.WriteLine(" Negative Number .");
            }

        }
        //combination of logical operators cannot be supported by switch 
        //only conditional operators are supported by switch like !-,==
       public void method5()
        {

            int a;
            Console.WriteLine("Enter number :");
            a = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            if (a > 0)
            {
                res = 1;
            }
            else
            {
                res = 0;
            }
                switch (res)
                {
                    case 1: Console.WriteLine(" Positive Number ."); break;

                    case 2: Console.WriteLine(" Negative Number ."); break;

                    default: Console.WriteLine("not a number"); break;
                }

        }
       

    }
}
