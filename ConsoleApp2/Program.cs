using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Covjek kreso = new Covjek("kreso", "Suput", 23);
            Console.WriteLine(Covjek.getNumOfEmployess());
            List<Covjek> All = new List<Covjek>();
            All.Add(kreso);
            //All.ForEach.ToString(Console.WriteLine);
            foreach (object o in All)
            {
                Console.WriteLine(o.ToString());
            }
            Console.ReadLine();


            
            }
    }


    class Command
    {
        public static List<Covjek> All = new List<Covjek>();

        public static string Help()
        {
            Console.WriteLine("Add, Remove, Display, List, <>List");
        }
        public static void Add(Covjek novi)
        {
            All.Add(novi);

        }

        public static void Remove(string prezimeZaIzbacit)
        {
            for (int i = Covjek.getNumOfEmployess-1; i >= 0; i--)
            {
                if (All[i].lastName == prezimeZaIzbacit)
                {
                    All.RemoveAt(i);
                }
            }
        }
        public static void Display()

        {
            //Console.WriteLine(Covjek.getNumOfEmployess());
            //Consule.Readline();

            foreach (object o in All)
            {
                Console.WriteLine(o.ToString());
            }
            Console.ReadLine();


            }
        public static void List()
        { // ko display al izbacit iz liste CEO 
          // (pretrazit arrey po kljucnoj rijeci i remove
          //{ }

        }
    }
    class Role
    {

    }
    class Covjek
    {
        //ovo je roditelj klasa za sve sto je isto
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age;
        public int Age
        { get { return age; }
          set { age = value; }

        }

        public Covjek ()
        {
            this.firstName = "No Name";
            this.lastName = "No LastName";
            this.age = 0;
            numOfEmployees++;
        }
        public Covjek (string firstName, string lastName, int age)
        {
            
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            numOfEmployees++;

        }
        public override string ToString()
        {
            return String.Format("{0} {1} , {2} godine ", firstName, lastName, age);
        }

        static int numOfEmployees = 0;
        public static int getNumOfEmployess()
        {
            return numOfEmployees;
        }
    }
    class PM : Covjek
    {
        public string Project { get; set; }
        public PM() : base()
        {
            this.Project = "No project";

        }
        public PM(string firstName, string lastName, int age, string Project) : base(firstName, lastName, age)
        {
            this.Project = Project;

        }
    }

    class DEV : PM
    {
        public bool IsStudent { get; set; }
        public DEV() : base()
        {
            bool isStudent = false;

        }
        public DEV (string firstName, string lastName, int age, string Project, bool IsStudent) : base(firstName, lastName, age, Project)
        {
            this.IsStudent = IsStudent;
        }
    }

    class DSNR : PM
    {
        public bool canDraw { get; set; }
        public DSNR() : base()
        {
            bool canDraw = false;

        }
        public DSNR (string firstName, string lastName, int age, string Project, bool canDraw) : base(firstName, lastName, age, Project)
        {
            this.canDraw = canDraw;
        }
    }

    class ST : PM
    {
        public bool UsesAutomatedTests { get; set; }
        public ST() : base()
        {
            bool UsesAutomatedTests = false;

        }
        public ST(string firstName, string lastName, int age, string Project, bool UsesAutomatedTests) : base(firstName, lastName, age, Project)
        {
            this.UsesAutomatedTests = UsesAutomatedTests;
        }
    }
}