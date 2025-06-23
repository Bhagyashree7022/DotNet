using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDemo0
{
    class Fruits {

        protected String color;
        public Fruits(String color) { 
        this.color = color;
        }
        public String getColor() {
            return color;
        }

    }
    class Mango: Fruits {

        int size;
        public Mango(String color,int size) : base(color) {
            this.size = size;
        }
        public int getSize() {
            return size;
        }

        
    }//until here it  is single level inheritance 

    class Seed :Mango{
        int weight;
        public Seed(String color, int size, int weight) :base(color,size){ 
        this.weight = weight;
        }
        public int getWeight() {
            return weight;
        }
    }//until here it  is multi level inheritance

    class WaterMelon: Fruits
    { 
        String taste;
        public WaterMelon(string color,String taste) : base(color)
        {
            this.taste= taste;     
        }
        public String getTaste()
        {
            return taste;
        }
    }
    //it is hierarchical inheritance Fruits=> (WaterMelon - Mango)Siblings

    /*class Seeedr : WaterMelon, Mango { 
    }
      Single base class xnnot have multiple parents i.e multiple inheritance not supported .
    */

    internal class InheritanceTypes
    {
        public void test() {

            //parent class
            Console.Write("Parent Proprties : ");
            Fruits f = new Fruits("Orange");
            Console.WriteLine( f.getColor());
            
            //child class 
            Console.Write("Child  Proprties :");
            Mango m = new Mango("Green",20);
            Console.Write(m.getColor()+" ");//parent method
            Console.WriteLine(m.getSize());//own method

            //Grand child
            Console.Write("Grand Child  Proprties :   ");
            Seed s = new Seed("Red",4,50);
            Console.Write(s.getColor()+" ");//grand parent method
            Console.Write(s.getSize()+" ");//parent method
            Console.WriteLine(s.getWeight());//own method

            //reference =>parent object=>child
            Fruits fru = new Mango("Yello",35);// Valid: Child assigned to Parent => callled Upcasting
            Console.Write("After upcasting : ");
            Console.WriteLine(fru.getColor());//whose reference its method invokedis 
           // Console.WriteLine(fru.getSize());

            //reference =>child object=>parent
            /*Mango mn = new Fruits("Yello"); Downcasting not automatic
             *  You cannot assign a base class instance to a derived class reference.
                Because the base class doesn’t know about the additional members or behavior in the child class mango */

            /*Fruits fm = new Fruits("Purple");  
            Mango mn =(Mango)fm; //allowed
            Console.WriteLine("after Downcasting ");
            Console.WriteLine(mn.getColor());
            Console.WriteLine(mn.getSize());*/ //downcasting throws unchecked exception

            Console.Write("Hierarchical Inheritance : ");
            WaterMelon w = new WaterMelon("Red","Sweet");
            Console.Write(w.getColor() + " ");
            Console.Write(w.getTaste());    

        }
    }
}
