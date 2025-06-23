using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDemo0
{
    class Dept {

        private int id;
        private String dname;

        public Dept(int id, String dname) { 
           this.id = id;   
            this.dname = dname;
        }

      
        public int Id { 
            
            get { return id; }
            set {
                if (value > 0)
                {
                    this.id = value;
                }
                }
            }


            public String DName
        {
            get { return dname; }
            set
            {
                this.dname = value;
            }

        }

            public override string ToString()
        {
            return $"deptid :{id} ,deptName: {dname}";
        }
    }       

    class Emp {

        private int id;
        private String eName;
        private String contact;
        private String add;
        private Dept dept;

        public int Id {
            set {
                this.id = value;
            } get
            {
                return id;
            }
        }

        public String EName {
            set {
                this.eName = value;
            }
            get {
                return eName;
            }


        }

        public String Phone
        {
            get { return contact; }
            set
            {
                this.contact = value;
            }
        }

         public String Address{
            get { return add; }
            set { this.add = value; }
        }

        public Dept Department
        {

            set { dept = value; }
            get { return dept; }
        }

        public override string ToString()
        {
            return $"EmpId : {id} ,EName :{eName}, Address :{add} ,Phone :{contact},dept: {dept}";
        }

    }

    internal class Day03_assg
    {

        public void  test() {

            Dept d = new Dept(4,"HR");
            Console.WriteLine(d.ToString());

            Console.WriteLine("Enter department name := ");
            d.DName=Console.ReadLine();
            Console.WriteLine("Enter dept id :=");
            d.Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(d.ToString());

             Emp e = new Emp();

            Console.WriteLine("Enter Employee name := ");
            e.EName = Console.ReadLine();
            Console.WriteLine("Enter dept id :=");
            e.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Address := ");
            e.Address = Console.ReadLine();
            Console.WriteLine("Enter Employee Phone:= ");
            e.Phone = Console.ReadLine();
            e.Department = d;
            Console.WriteLine(e.ToString());

        }
    }
}
