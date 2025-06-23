using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace myDemo0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int num1, num2;
            Console.WriteLine("Enter 1st  number :");
            num1  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter choie \n 1.Addition 2. Substraction \n 3.Product \n 4.Division \n5.Remainder ");
            int ch = Convert.ToInt32(Console.ReadLine());
           switch(ch) {
                case 1: Console.WriteLine("Sum : " + (num1 + num2));break;
                case 2: Console.WriteLine("Subtraction : " + (num1 - num2));break;
                case 3: Console.WriteLine("Product : " + (num1 * num2));break;
                case 4: Console.WriteLine("Division : " + (num1 / num2));break;
                case 5: Console.WriteLine("Modulus : " + (num1 % num2));break;

            }*/
            //Console.ReadLine();
            /* InputData obj = new InputData();
             obj.method1();
             obj.method2();
             obj.method3();
             obj.method4();
             obj.method5();*/

            Day01_assg d1 = new Day01_assg();
            //d1.tempConv();
            //d1.bankSys();
            // d1.bill();

            //day02
            /* ArrayLoop al = new ArrayLoop();
             al.twoD();
             InheritanceTypes ex = new InheritanceTypes();
             ex.test();
             InhertanceAbstract ab=new InhertanceAbstract();
             ab.test();
            Interface i=new Interface();
            i.test();*/

            // Day02_assg d2 = new Day02_assg();
            //d2.stateCity();
            //d2.callRemaind();

            //day03
            /* InterfaceExample interfaceExample = new InterfaceExample();
             interfaceExample.test();*/

            Day03_assg d3 = new Day03_assg();
            d3.test();

            //Day04
            /*try
            {
                MyCustomExceptions.method1();
            }
            catch (UserDefinedException ex) 
            {
                 Console.WriteLine(ex.Message);
            }
            //CollectionExample.listGenericMethod();
            CollectionExample.listGenericMethod1();
             CollectionExample.arrayClassExample();
            
            try {
                InvalidUserExcepExample.test();
            }
            catch (InvalidException ex ) { 
                Console.WriteLine(ex.Message);
                 foreach(var errors in ex.Errors)
                    Console.WriteLine(errors);
            }*/
           // Any.testReentryException();

        }
    }
}
