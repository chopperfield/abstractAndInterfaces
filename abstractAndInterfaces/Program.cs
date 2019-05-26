using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractAndInterfaces
{
    public abstract class Employee
    {
        //We can have fields and properties

        //In the Abstract Class
        protected string id;
        protected string lname;
        protected string fname;

        //Properties
        public abstract String ID
        {
            get;set;
        }
        public abstract String FirstName
        {
            get;set;
        }
        public abstract String LastName
        {
            get;set;
        }
        
        //Completed Methods
        public string Update()
        {
            return "Employee " + id + " " + lname + " " + fname + " updated";
        }
        public string Add()
        {
            return "Employee " + id + " " + lname + " " + fname + " added";
        }
        public string Delete()
        {
            return "Employee " + id + " " + lname + " " + fname + " deleted";
        }
        public string Search()
        {
            return "Employee " + id + " " + lname + " " + fname + " found";
        }
        //abstract method that is different 
        //from Fulltime and Contractor
        //therefore i keep it uncompleted and 
        //let each implementation 
        //complete it the way they calculate the wage.
        public abstract String CalculateWage();

        //testing
        public virtual void virMeth() { Console.WriteLine("virtual method from abs"); }
    }

    public class Emp_Fulltime : Employee
    {
        //uses all the properties of the 
        //Abstract class therefore no 
        //properties or fields here!
        public Emp_Fulltime() { }
        
        public override string ID
        {
            get { return id; }
            set { id = value; }
        }
        public override string FirstName
        {
            get { return fname; }
            set { fname = value; }
        }
        public override string LastName
        {
            get { return lname; }
            set { lname = value; }
        }

        //common methods that are 
        //implemented in the abstract class
        public new string Add()
        {
            return base.Add();
        }
        public new string Update()
        {
            return base.Update();
        }
        public new string Delete()
        {
            return base.Delete();
        }
        public new string Search()
        {
            return base.Search();
        }

        //abstract method that is different 
        //from Fulltime and Contractor
        //therefore I override it here.
        public override String CalculateWage()
        {
            return "Full time employee " +
                  base.fname + " is calculated " +
                  "using the Abstract class...";
        }
    }


    public interface Iemployee
    {
        //cannot have fields. uncommenting 
        //will raise error!
        //        protected String id;
        //        protected String lname;
        //        protected String fname;


        //just signature of the properties 
        //and methods.
        //setting a rule or contract to be 

        //followed by implementations.
        String ID
        {
            get;
            set;
        }
        String FirstName
        {
            get;
            set;
        }
        String LastName
        {
            get;
            set;
        }

        // cannot have implementation
        // cannot have modifiers public 
        // etc all are assumed public
        // cannot have virtual
        String Update();
        String Add();
        String Delete();
        String Search();
        String CalculateWage();                
    }

    public class Emp_Fulltime2 : Iemployee
    {
        //All properties and Field are define here!
        protected String id;
        protected String lname;
        protected String fname;

        public Emp_Fulltime2()
        {

        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return fname; }
            set { fname = value; }
        }
        public string LastName
        {
            get { return lname; }
            set { lname = value; }
        }
        public string Add()
        {
            return "Fulltime Employee " +
                     fname + " added.";
        }
        public string Delete()
        {
            return "Fulltime Employee " +
                      fname + " deleted.";
        }
        public string Search()
        {
            return "Fulltime Employee " +
                     fname + " searched.";
        }
        public string Update()
        {
            return "Fulltime Employee " +
                        fname + " updated.";
        }

        public string CalculateWage()
        {
            return "Full time employee " +
               fname + " caluculated using " +
               "Interface.";
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            //This is the sub that tests both 
            //implementations using Interface and Abstract

            Emp_Fulltime emp = new Emp_Fulltime();
            emp.ID = "2244";
            emp.FirstName = "Maria";
            emp.LastName = "Robinlius";
            Console.WriteLine(emp.Add().ToString());
            Console.WriteLine(emp.CalculateWage().ToString());

            Console.WriteLine("===============================");
            Iemployee Iemp;

            Emp_Fulltime2 emp2 = new Emp_Fulltime2();
            emp2.ID = "2234";
            emp2.FirstName = "Rahman";
            emp2.LastName = "Mahmoodi";
            Console.WriteLine(emp2.Add().ToString());
            Console.WriteLine(emp2.CalculateWage().ToString());

            Console.WriteLine("===============================");

            Iemp = emp2;
            Iemp.ID = "123";
            Iemp.FirstName = "David";
            Iemp.LastName = "Mahmoodi";
            Console.WriteLine(emp2.Add().ToString());
            Console.WriteLine(emp2.CalculateWage().ToString());

            Console.WriteLine("Press any key . . .");
            Console.ReadKey();
        }
    }
}
