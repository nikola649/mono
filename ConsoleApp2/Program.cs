using System;
using System.Collections;
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

            Command.Help();
            string keyword;
            Boolean quitNow = false;
            while(!quitNow)
            {
               keyword = Console.ReadLine(); 
               keyword.ToUpper();
               switch (keyword)
               {
                  case "HELP":
                    Command.Help();
                          break;

                   case "ADD":
                     Command.Add();
                     break;

                   case "REMOVE":
                     Command.Remove();
                     break;

                   case "DISPLAY":
                        Command.Display();
                        break;
                        
                   case "lIST":
                        Command.List();
                        break;
                        
                   case "PMlIST":
                        Command.PMList();
                        break;
                  //sad jos sve ostale specijalne liste...

                    case "QUIT":
                      quitNow = true;
                      break;

                    default:
                      Console.WriteLine("Unknown Command " + keyword);
                      break;
               }
            }
     
            /*
            Employee kreso = new Employee("kreso", "Suput", 23);
            Console.WriteLine(Employee.getNumOfEmployess());
            List<Employee> All = new List<Employee>();
            All.Add(kreso);
            //All.ForEach.ToString(Console.WriteLine);
            foreach (object o in All)
            {
                Console.WriteLine(o.ToString());
            }
            Console.ReadLine();

            */
            
        }
    }


    class Command
    {
        
        public static ArrayList All = new ArrayList();
        //public static List<Employee> All = new List<Employee>();
  
        public static string Help()
        {
            Console.WriteLine("Possible commands: Add, Remove, Display, List, <>List");
        }
        public static void Add()
        {   
            Console.WriteLine("What role?");
            uloga = Console.ReadLine(); 
            uloga.ToUpper();

               switch (uloga)
               {
                  case "PM":
                    PM novi = new PM{};
                    All.Add(PM);
                          break;

                   case "ADD":
                     Command.Add(keyword);
                     break;

                   case "REMOVE":
                     Command.Remove();
                     break;

                   case "DISPLAY":
                        Command.Display();
                        break;
                        
                   case "lIST":
                        Command.List();
                        break;
               }      
               
        }

        public static void Remove(string prezimeZaIzbacit)
        {
            //for (int i = All.Capacity; i>=0;i--)
            for (int i = Employee.getNumOfEmployess-1; i >= 0; i--)
            {
                if (All[i].lastName == prezimeZaIzbacit)
                {
                    All.RemoveAt(i);
                }
            }
        }
        public static void Display()

        {
            foreach (object o in All)
            { 
                Console.WriteLine(o.ToString());
            }
            Console.ReadLine();
            
            // za broj koliko ih jeConsole.WriteLine(Employee.getNumOfEmployess());
            //Consule.Readline();
            }
        public static void List()
        { 
            
            foreach (object o in All)
            {
                if(o.role== Role.CEO )
                    continue;
                
                Console.WriteLine(o.ToString());
            }
            Console.ReadLine();
         
          // ko display al izbacit iz liste CEO 
          // (pretrazit arrey po kljucnoj rijeci i remove
          //{ }

        }
        public static void PMList()
        { 
            
            foreach (object o in All)
            {
                if(o.role== Role.PM)
                
                        Console.WriteLine(o.ToString());
            }
            Console.ReadLine();
        }
    }

    
    public enum Role
    {
        CEO, PM, DEV, DSNR, ST
    }



    public class Employee
    {
        public Role role;
        //ovo je roditelj klasa za sve sto je isto
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age;
        public int Age
        { get { return age; }
          set { age = value; }

        }
        
            public Employee ()
        {
            this.firstName = "No Name";
            this.lastName = "No LastName";
            this.age = 0;
            numOfEmployees++;
        }
        public Employee (string firstName, string lastName, int age)
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
    
    class PM : Employee
    {
        public string Project { get; set; }
        public PM() : base()
        {
            this.role= Role.PM;
            
            this.Project = "No project";

        }
        public PM(string firstName, string lastName, int age, string Project) : base(firstName, lastName, age)
        {
            this.role= Role.PM;
            this.Project = Project;

        }
    }

    class DEV : PM
    {
        
        public bool IsStudent { get; set; }
        public DEV() : base()
        {
            this.role= DEV;
         
            bool isStudent = false;

        }
        public DEV (string firstName, string lastName, int age, string Project, bool IsStudent) : base(firstName, lastName, age, Project)
        {
            
            this.role= DEV;
         
            this.IsStudent = IsStudent;
        }
    }

    class DSNR : PM
    {
        public bool canDraw { get; set; }
        public DSNR() : base()
        {
               
            this.role= DSNR;
         
            bool canDraw = false;

        }
        public DSNR (string firstName, string lastName, int age, string Project, bool canDraw) : base(firstName, lastName, age, Project)
        {
            
            this.role= DSNR;
         
            this.canDraw = canDraw;
        }
    }

    class ST : PM
    {
        public bool UsesAutomatedTests { get; set; }
        public ST() : base()
        {
               
            this.role= ST;
         
            bool UsesAutomatedTests = false;

        }
        public ST(string firstName, string lastName, int age, string Project, bool UsesAutomatedTests) : base(firstName, lastName, age, Project)
        {
            
            this.role= ST;
         
            this.UsesAutomatedTests = UsesAutomatedTests;
        }
    }

}
