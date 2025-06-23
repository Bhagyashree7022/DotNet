using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace myDemo0
{
    public class InvalidException:Exception {

        public List<String> Errors { get; }
        public InvalidException(List<String >errors):base("Invalid Exception") { 
            Errors = errors;
        
        }
        public override string ToString() { 
          return $"{Message}:{string.Join(";",Errors)}";
        }
    }
    internal class InvalidUserExcepExample
    {

        public static bool validateUser(int age,String city) { 
        
            List<String> exceptionList = new List<String>();
            while (true)
            {
                if (age < 0 || age > 100)
                {
                    exceptionList.Add("Invalid Age");
                }
                String[] validCities = new string[] { "Mumbai", "Pune", "Nashik", "Nagpur" };
                if (!validCities.Contains(city))
                {
                    exceptionList.Add("Invalid City");
                }

                if (exceptionList.Any())
                {
                    throw new InvalidException(exceptionList);
                }
                return true;
            }
        }
        public static void test() {
            Console.WriteLine("Enter city:=");
            String city=Console.ReadLine();
            Console.WriteLine("Enter age:=");
            int age = Convert.ToInt32(Console.ReadLine());
            validateUser(age, city);

        }
    }
}
