using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDemo0
{
    abstract class Shape//provide common interface
    {
        abstract public double area();
    }
    abstract class Size//provide common interface
    {
        abstract public void aperimeter();
    }
    //class Rectangle : Shape ,Size{ } // also base cannot derived from multiple base class

    class Rectangle : Shape //show error until we override abstract methods
    {
        int l, b;
        public Rectangle(int l, int b)
        {
            this.l = l;
            this.b = b;
        }
        public override double area()
        {
            return(l*b);
        }

    }
    internal class InhertanceAbstract
    {
        public void test() {

            // Shape s=new Shape();  throws error cannot create onject of abstract class 
            Rectangle r = new Rectangle(10, 20);
            Console.WriteLine(r.area());    
            
        }

    }
}
