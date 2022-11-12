using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsInC
{
    public class Student
    {
        //fields
        public string Name;
        public string Matricule;
        public string Level;
        public string Department;

        //properties
        public string name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string matricule
        {
            get
            {
                return this.matricule;
            }
            set
            {
                this.name = matricule;
            }
        }
        public string level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = level;
            }
        }

        public string department
        {
            get
            {
                return this.department;
            }
            set
            {
                this.name = department;
            }
        }

        //defining constructor
        public Student()
        {
            string studName = Console.ReadLine();
            string studMatricue = Console.ReadLine();
            string studLevel = Console.ReadLine();
            string studDepartment = Console.ReadLine();

            this.name = studName;
            this.matricule = studMatricue;
            this.level = studLevel;
            this.department = studDepartment;
        }
        //method for output
        public void displayStudent()
        {
            Console.WriteLine("Student information");
            Console.WriteLine("My name is {0}, my matricule is {1} and my level is {2} found in the department {3}");
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.displayStudent();
            Console.ReadKey();


        }
    }
}
