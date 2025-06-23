using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDemo0
{
    public class UserDefinedException:Exception
    {

        
        public UserDefinedException(String message) { 
       
        }
    }
    internal class MyCustomExceptions
    {
        public static void method1() {

            throw new UserDefinedException("User defined Exception!");
            throw new DivideByZeroException();
        }
    }
}
