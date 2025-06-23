using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDemo0
{
    internal class Any
    {
        public static void testReentryException() {
            bool success = false;
            while (!success) {
                try
                {
                    Console.WriteLine("Enter age " );
                    int age =Convert.ToInt32( Console.ReadLine());
                    if (age < 0 || age > 100)
                    {
                        throw new ArgumentOutOfRangeException("Age must be more than 0 and <100");
                        
                    }
                    success = true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please Enter age ");
                }
            }
        }

    }
}
