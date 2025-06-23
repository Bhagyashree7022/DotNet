using myDemo0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static myDemo0.InterfaceExample;

namespace myDemo0
{
    internal class InterfaceExample
    {
        public void test()
        {
            Bird b = new Bird();

            /*b.Fly();        // ❌ Error: Fly is explicitly implemented
            b.IJump.Jump(); // ❌ Error: Can't access interface this way
            */
            ((IFly)b).Fly();// // Access via interface casting
            ((IJump)b).Jump();
        }
    }
    public interface IFly
    {
        //to access private variable we use geter setters  using it give 0one layer of abstraction so any one cannot modify it
        //
        void Fly();
    }
    public interface IJump
    {

        void Jump();
    }

}
public class Bird : IFly, IJump
{
    void IFly.Fly()
    {
        Console.WriteLine("Birds fly ");

    }
    void IJump.Jump()
    {
        Console.WriteLine("Birds is jumping ");
    }

   

}
