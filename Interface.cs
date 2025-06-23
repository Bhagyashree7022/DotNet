using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDemo0
{
    public interface Sbi
    {
        //public void withdraw();  give error always interface methods are not public
        void withdraw() ;
    }

    public interface Union
    {
        void deposit () ;
        void fly(double r);
    }

    public interface Janta
    {
        void deposit() ;
        void fly(int r);
    }

    class Bank : Sbi, Union ,Janta//like that base class derived from multiple interfaces so multiple inheritance achived 
    { 
       public void withdraw() //here it public becoz we access by making its object
        {
            Console.WriteLine("In SBI  withdraw ");
        }
        void Janta.fly(int r) {
            Console.WriteLine("In Janta deposit  ");
        }

        void Union.fly(double r)
        {
            Console.WriteLine("In Union deposit  ");
        }
        public void deposit()// no parameters so both we give common defination
            // in case of parameterized aeeential to explicitly denote its interface
            //to avoid confusion about from which interface  it come
        { 

        }


    }
    internal class Interface
    {
        public void test() 
        { 
            Bank b=new Bank();//here is no interfaces have same name method 
            ((Janta)b).deposit();
            ((Union)b).deposit();
            b.withdraw();

        }
    }
}
