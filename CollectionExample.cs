using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace myDemo0
{

   
    internal class CollectionExample
    {
        public static  void listMethod()
        {
            //it collect elements hence give {} to add elements
            //here we give data and also memory 
            ArrayList numbers = new ArrayList { 1, 2, 3, 5, 4 };

            ArrayList num = new ArrayList();

            //operations 
            numbers.Add(5);
            numbers.Add(8);
            numbers.Add(9);
            numbers.Add(10);
            numbers.Add("Bhagya");

            foreach (int n in num)
            {
                Console.WriteLine(n);
            }

            num.Remove(0);

            foreach (int n in num)
            {
                Console.WriteLine(n);
            }
        }
        // Generic collection has compile time checking 
        //non generic collection has run time checking
        public static void listGenericMethod1() 
        { 
          List<String> numbers = new List<String>();
            numbers.Add("a");
            numbers.Add("num");
            numbers.Add("poj");
            numbers.Add("Bhagya");

            foreach (String  n in numbers)
            {
                Console.Write(n+" ");
            }
            List<int> numbers1 = new List<int>();
            numbers1.Add(78);
            numbers1.Add(56);
            numbers1.Add(45);
            numbers1.Add(96);
            Console.WriteLine();

            foreach (int n in numbers1)
            {
                Console.Write(n);
            }
        }
        public static void arrayClassExample()
        {
            int[] numbers = { 8,9,5,2,6,4,7 };
            Array.Sort(numbers);// by default sort in ascending
            Console.WriteLine(string.Join(", ", numbers));
            Array.Reverse(numbers);
            Console.WriteLine(string.Join(", ", numbers));

        }

    }
}
