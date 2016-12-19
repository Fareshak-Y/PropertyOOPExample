using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyOOPExample
{
    class Program
    {
        // Private fields 
        private int Emp_Id;
        private string Emp_Name = string.Empty;

        //ID Property Declaration; With Two Properties. Get is for reading the value and Set is for writing the value fo a field
        public int ID
        {
            //Get is use for Reading field 
            get
            {
                return Emp_Id;
            }
            //Set is use for writing field 
            set
            {
                Emp_Id = value; //The value keyword is always used in the set method, for writing data into a field. 
            }
        }

        //Name Property Declaration 
        public string Name
        {
            //Get is use for Reading field 
            get
            {
                return Emp_Name;
            }
            //Set is use for writing field 
            set
            {
                Emp_Name = value;
            }
        }


        static void Main(string[] args)
        {
            //Create an object of Program class. 
            Program Prg = new Program();
            Prg.ID = 7;
            Prg.Name = "Larrt Page";
            Console.WriteLine("Employee Id:={0}", Prg.ID);
            Console.WriteLine("Employee Name:={0}", Prg.Name);
            Console.ReadLine();
        }
    }

}

//In the preceding example, we have the following two private fields: 
//Emp_Id(int)
//Emp_name(string)