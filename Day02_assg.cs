using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDemo0
{
    internal class Day02_assg
    {
        public void stateCity()
        {

            Console.WriteLine("Enter no of states := ");
            int noOfState = Convert.ToInt32(Console.ReadLine());

            String[] states = new String[noOfState];
            String[][] statesCities = new string[noOfState][];

            for (int i = 0; i < states.Length; i++)
            {
                Console.WriteLine("Enter name of state := ");
                states[i] = Console.ReadLine();

                Console.WriteLine("Enter no of Cities := ");
                int noOfCities = Convert.ToInt32(Console.ReadLine());

                statesCities[i] = new string[noOfCities];
                Console.WriteLine("Enter Cities names := ");
                for (int j = 0; j < noOfCities; j++)
                {
                    statesCities[i][j] = Console.ReadLine();
                }
            }

            for (int i = 0; i < statesCities.Length; i++)
            {
                Console.WriteLine("State " + states[i]);
                Console.Write("cities: ");
                Console.WriteLine(string.Join(", ", statesCities[i]));
                Console.WriteLine();
            }
        }

        public void callRemaind() {

            Console.WriteLine("Enter dividend := ");
            int divi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter divisor := ");
            int div = Convert.ToInt32(Console.ReadLine());

            int q = divi / div;
            Console.WriteLine(" Division is := "+q);
            int r=divi-(q* div);
            Console.WriteLine("Remainder is := " + r);


        }
    }
}
