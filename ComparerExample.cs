using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDemo0
{
    public class Student :IComparable <Student> {
        
        public String name { set; get;}
        public int age { set; get; }
        public int ComparareTo(Student other) {
            if (other == null) return 1;
            return this.age.CompareTo(other.age);
        
        }
        public override String ToString() {
            return $"name :{name} , age : {age}";
        }
    
    }
    internal class ComparerExample
    {
    }
}
