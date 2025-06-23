using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDemo0
{
    internal class VariableArgs
    {

        public static  void sumArray(params int[] number) {

            int sum = 0;
            foreach(int n in number)
                       sum += n;

             Console.WriteLine("Sum :" + sum);

        }
    }
}
