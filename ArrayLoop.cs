using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace myDemo0
{//namespace name is like package donot give same name to calss
    internal class ArrayLoop
    {
        public void m1()
        {
            int[] numbers = { 1, 2, 3 };
            int[] numbers2 = new int[5];
            int[] numbers3 = new int[5] {3,4,5,6,7};

            Console.WriteLine("2nd number : "+numbers[1]);
            Console.WriteLine(numbers[0]);
            for (int i = 0; i < numbers.Length; i++)// in this from anywhere we start any where we stop  
            {//Length is capital "L" 
              Console.WriteLine("index : "+i+" "+numbers3[i]);
            }
            //in for we go in forward and backward also we stop at anyindex but in collection not possible
            //in for we use print,scanner but inforeach only read ollection element if we want to try gives error 
            //inside for we give input data 
            //foreach:  start  0 :end at collection :forward only (not i-- there ):READ Only loop
            //it will work only with collections  as int for(int i=0;i<n;i++)print(i); is not work in foreach
            //in foreach we read only i.e. we cant use input to accept data from user 
            /* Synatax foreach(datatype Identifier In CollectionName)*/
            foreach (int n in numbers)
            { 
                Console.Write(numbers[n]);
            }

        }

        public void twoD() {
            //define int[][]=>row,column 
            int[,] numbers = {
                              { 2,3 },
                             { 4,5,}
                      };

            int[,] twoArr = new int[3, 3];
            int[,] tooArr1 = new int[3, 3] {
                       { 1,2,3},{4,5,6 },{7,8,9}
        };
            Console.WriteLine("Elements of two Dimension Array using for each := ");
            foreach (int n in tooArr1) { 
                Console.Write(n+" ");
            
            }
            Console.WriteLine();

            //using loop
            Console.WriteLine("Elements of 2d Array using for := ");
            for(int i=0;i < numbers.GetLength(0);i++)
            {
                for(int j = 0; j < numbers.GetLength(1); j++)
            {
                    Console.Write( numbers[i,j]+" ");
                }
                Console.WriteLine();
            }
            //using index 
            Console.WriteLine("2nd row 2nd element := " + numbers[1,1]);
        }
       
    }
}
