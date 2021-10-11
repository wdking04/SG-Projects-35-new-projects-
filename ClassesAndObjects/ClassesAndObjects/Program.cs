using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    #region Enums
    //Instead of hard-coding numbers that lose meaning, use enums
    public enum OrderStatus
    {
        Quoted, //0 - or we could start our enum with 1, Quoted = 1
        Purchased, //1
        Shipped, //2
        Delivered //3
    }

    public class Order
    {
        //Create public property Status of the OrderStatus type (the enum)
        public OrderStatus Status { get; private set; }

        //here we use enums to advance the status to the next step 
        //note that we are passing an int as a parameter so we 
        //need to convert the enum member to int for comparison
        public void AdvanceStatus(int status)
        {
            switch (status)
            {
                case (int)OrderStatus.Quoted:
                    Status = OrderStatus.Purchased;
                    break;
                case (int)OrderStatus.Purchased:
                    Status = OrderStatus.Shipped;
                    break;
                case (int)OrderStatus.Shipped:
                    Status = OrderStatus.Delivered;
                    break;
            }
        }

        public string OrderProcessed(int status)
        {
            //When comparing an int to the enum member you must 
            //convert it to the enum type
            if ((OrderStatus)status == OrderStatus.Shipped || (OrderStatus)status == OrderStatus.Delivered)
            {
                return $"Order {Enum.GetName(typeof(OrderStatus), status)}";
            }
            else
            {
                return "Order Still In Warehouse";
            }
        }
    }
    #endregion

    #region Class Objects

    //Employee class which has the properties of an employee object, Name and Payrate
    public class Employee
    {
        public Employee(string name, decimal payrate)
        {
            this.Name = name;
            this.PayRate = payrate;
        }
        public string Name { get; set; }
        public decimal PayRate { get; set; }
    }

    //This would actually be a data layer class which interacts with database
    //we will simulate a returned dataset and parse into employee objects 
    public class EmployeeDatabase
    {
        public List<Employee> GetActiveEmployes()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee("Navani", 45.5m));
            list.Add(new Employee("Venli", 42.5m));
            return list;
        }
    }

    //This is the class that invokes the message to 'ProcessPayroll'
    public class PayrollCalculator
    {
        public void ProcessPayroll()
        {
            EmployeeDatabase database = new EmployeeDatabase();
            List<Employee> employees = database.GetActiveEmployes();
            SendPrintRequest(employees);

        }

        public void SendPrintRequest(List<Employee> employees)
        {
            PaycheckPrinter paycheck = new PaycheckPrinter();
            paycheck.PrintPaycheck(employees);
        }
    }

    public class PaycheckPrinter
    {
        //we will simulate the printing of paychecks with a Console.Writeline
        //of employee name and payrate
        public void PrintPaycheck(List<Employee> employees)
        {
            string paycheckMessage = "";
            foreach (Employee employee in employees)
            {
                paycheckMessage += $"{employee.Name} Payrate:  {employee.PayRate}\n";
            }
            Console.WriteLine(paycheckMessage);
        }
    }
    #endregion

    #region Constants
    public class Physics
    {
        // speed of light in a vacuum
        public const int SpeedOfLight = 299792458;
        // gravitational constant
        public const double GravitationalConstant = 6.67384;
    }
    #endregion

    #region Static Class
    public static class AllStatic
    {
        //public int NonStaticInt;

        public static int StaticInt;
    }
    #endregion

    #region Constructors
    public class TodayDate
    {
        private DateTime _todayDate;
        public DateTime GetDate { get { return _todayDate; } }

        //the constructor will assign the date to the GetDate property
        //when class is instantiated
        public TodayDate()
        {
            _todayDate = DateTime.Now;
        }
    }

    public class PersonOne
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //here we are overloading our constructors so we can 
        //instantiate with or without passing parameters
        public PersonOne()
        {
        }

        public PersonOne(string firstName, string lastName, int age)
        {
            //store the constructor values in the instance properties
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }

    public class PersonTwo
    {
        //With Object Initializer Syntax, we no longer need the parameter constructor
        //to pre-set our properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class Goblin1
    {
        //If no level is provided, the level shall be 1
        //If no name is provided, the name shall be Generic Goblin
        public int Level { get; set; }
        public string Name { get; set; }

        //The this keyword always refers to “this object” or the current instance
        public Goblin1() : this(1, "Generic Goblin")
        {
        }

        public Goblin1(string name) : this(1, name)
        {
        }

        public Goblin1(int level) : this(level, "Generic Goblin")
        {
        }

        public Goblin1(int level, string name)
        {
            Level = level;
            Name = name;
        }
    }

    public class ReadOnlyKeyword
    {
        private readonly int _readOnlyInt;

        public ReadOnlyKeyword(int value)
        {
            _readOnlyInt = value;
        }

        public void AssignValueToReadOnlyInt()
        {
            //uncomment to see error
            //_readOnlyInt = 10;
        }
    }

    #endregion

    #region Partial Keyword
    //partial classes can be on seperate files as long as in same project
    public partial class Person
    {
        public int Age { get; set; }
    }

    public partial class Person
    {
        public string Name { get; set; }
    }
    //add another class file, Person.cs, and declare public partial
    //and add a City property
    //look at Person.cs to see the rest of this class
    #endregion

    #region Three Pillars

    //Here is our base class that has our base functionality for our other 
    //monster classes to inherit from 
    public class Creature
    {
        //change protected to private to see error in derived classes
        protected const int StartingHitPoints = 100;
        protected int _level;
        protected int _hitPoints;

        public void LevelUp()
        {
            _level++;
        }

        //constructors
        //the : this(1) means that if we pass no parameter when we instantiate
        //it will invoke the constructor that passes an int of a default 1 for
        //starting level
        public Creature() : this(1)
        {
        }
        public Creature(int startingLevel)
        {
            _hitPoints = StartingHitPoints;
            _level = startingLevel;
        }

        //the virtual keyword means that we can override the functionality in 
        //derived classes
        public virtual void Regen()
        {
            _hitPoints = Math.Min(StartingHitPoints, _hitPoints + 1);
            Console.WriteLine($"Regenerated!!  Points:  {_hitPoints}\n");
        }

        //Potion potion = new Potion();  //uncomment to see error if we try to instantiate Potion

        //using the abstract Potion class as Potion objects in a Stack collection
        Stack<Potion> _potions = new Stack<Potion>();
        public void AddHp(int hp)
        {
            _hitPoints = Math.Min(StartingHitPoints, _hitPoints + hp);
        }

        public void AddPotion(Potion p)
        {
            // push a potion onto the stack
            _potions.Push(p);
        }

        public void Drink()
        {
            // if we have any potions, drink the top one
            if (_potions.Peek() != null)
            {
                _potions.Pop().Drink(this);
            }
        }

        //we have a Level property of get only, so we can read the level
        public int Level { get { return _level; } }
    }

    //NOTE:  to call another constructor in the same class, you can use the this keyword;
    //and to call one in the base class, you use the base keyword
    //
    //we will inherit methods from the Creature class
    public class Goblin : Creature
    {
        public Goblin()
        {
        }
        public Goblin(int startingLevel) : base(startingLevel)
        {
            _level = startingLevel;
        }
    }

    public class Ogre : Creature
    {
        public Ogre()
        {
        }
        public Ogre(int startingLevel) : base(startingLevel)
        {
            _level = startingLevel;
        }
    }

    public class Hydra : Creature
    {
        public Hydra()
        {
        }
        public Hydra(int startingLevel) : base(startingLevel)
        {
            _level = startingLevel;
        }
    }

    public class Troll : Creature
    {
        public Troll()
        {
        }
        public Troll(int startingLevel) : base(startingLevel)
        {
            _level = startingLevel;
        }

        //the Troll class will override the Regen() method functionality
        //we want to add 3 additional points that the base Regen() method
        //we will use the base keyword to call the base.Regen() method which
        //adds 1 and does not go over 100 points
        public override void Regen()
        {
            _hitPoints += 3;
            base.Regen();
        }
    }

    //we can see polymorphism by using the return type of Creature to 
    //return many different types of monster
    public class MonsterGenerator
    {
        private const int NumberOfCreaturesAvailable = 4;
        private static Random _rng = new Random();

        public static Creature GenerateMonster()
        {
            //we don't need to instantiate the monsters with a starting level
            //unless we want to because our constructor in the Creature class
            //is taking care of passing a default
            switch (_rng.Next(NumberOfCreaturesAvailable))
            {
                case 0:
                    return new Goblin();
                case 1:
                    return new Ogre();
                case 2:
                    return new Hydra(3);
                default:
                    return new Troll(5);
            }
        }
    }

    //Be aware of the access modifiers
    //public - Available to any other objects in any assembly
    //private - Available only to members within the same object
    //protected - Available only to members in the same object and derived objects
    //internal - Available to any other objects in the same assembly, aka "public to project"
    //protected internal - Available to members in the same object and derived objects,
    //but only in the same assembly.
    //
    //this abstract class cannot be instantiated, it must be inherited from and we 
    //have one method Drink() that must be implemented by derived classes
    public abstract class Potion
    {
        //since this is an abstract void, it must be overriden and therefore we have 
        //no actual implementation, only a signature
        public abstract void Drink(Creature drinker);
    }

    public class HealingPotion : Potion
    {
        //if creature drinks a healing potion they get 5 points
        public override void Drink(Creature drinker)
        {
            Console.WriteLine("The healing potion heals you!");
            drinker.AddHp(5);
        }
    }

    public class PoisonPotion : Potion
    {
        //if creature drinks a poison potion they lose 15 points
        public override void Drink(Creature drinker)
        {
            Console.WriteLine("The poison potion hurts you!");
            drinker.AddHp(-15);
        }
    }

    public class BubblyPotion : Potion
    {
        //if creature drinks this they burp!
        public override void Drink(Creature drinker)
        {
            Console.WriteLine("Burp!");
        }
    }

    //like abstract requires inheritance, sealed prevents inheritance
    public sealed class HelloMessage
    {
        public void SendHello()
        {
            Console.WriteLine("Hello");
        }
    }

    ////uncomment to see error
    //public class MorningMessage : HelloMessage
    //{
    //    //Oh well it was worth a try
    //}

    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            EasyEnumerations();
            //ComparingEnums();
            //ProcessPaychecks();
            //UseConstructors();
            //Goblins1();
            //PartialPersonClass();
            //PlayWithMonsters();

            Console.ReadLine();
        }

        static void EasyEnumerations()
        {
            Order order = new Order();
            Console.WriteLine("Passing an integer:  ");
            Console.WriteLine(order.OrderProcessed(2));
            Console.WriteLine(order.OrderProcessed(3));
            Console.WriteLine(order.OrderProcessed(0));
            //but of course this defeats one of the purposes of enums
            //not having to remember what the numbers mean
            Console.WriteLine("\nPassing a OrderStatus member cast as an int:  ");
            Console.WriteLine(order.OrderProcessed((int)OrderStatus.Shipped));
            Console.WriteLine(order.OrderProcessed((int)OrderStatus.Delivered));
            Console.WriteLine(order.OrderProcessed((int)OrderStatus.Quoted));
        }

        static void ProcessPaychecks()
        {
            PayrollCalculator payroll = new PayrollCalculator();
            payroll.ProcessPayroll();
        }

        //Go to Tools > NuGet Package Manager > Manage NuGet Packages for Solution...
        //Go to Tools > NuGet Package Manager > Package Manager Console
        //Nuget packages are project-specific and travel with the package as a part of the project.
        //When using packages you do not have to check them into source control. When you open a project
        //that is missing packages, Visual Studio will automatically download and restore those
        //packages when you build
        //
        //Go to Extensions > Manage Extensions
        //Extensions work in all your own solutions or projects and do not travel with the project.

        static void UseConstructors()
        {
            //using the TodayDate class
            TodayDate instance = new TodayDate();
            Console.WriteLine($"Right now is {instance.GetDate}\n");

            //using the Person class without passing parameters
            PersonOne person1 = new PersonOne();
            person1.FirstName = "Adolin";
            person1.LastName = "Kholin";
            person1.Age = 31;

            //now with passing parameters
            PersonOne person2 = new PersonOne("Shallon", "Joveki", 28);

            //using a class with no parameters to assign properties with Object Initialzer Syntax
            PersonTwo person3 = new PersonTwo { FirstName = "Dalinar", LastName = "Kholin", Age = 53 };

            Console.WriteLine($"Name:  {person1.LastName}, {person1.FirstName} | Age: {person1.Age}");
            Console.WriteLine($"Name:  {person2.LastName}, {person2.FirstName} | Age: {person2.Age}");
            Console.WriteLine($"Name:  {person3.LastName}, {person3.FirstName} | Age: {person3.Age}\n");
        }

        static void Goblins1()
        {
            // Name = "Generic Goblin", Level = 1
            Goblin1 g1 = new Goblin1();
            // Name = "Joe", Level = 1
            Goblin1 g2 = new Goblin1("Joe");
            // Name = "Generic Goblin", Level = 5
            Goblin1 g3 = new Goblin1(5);
            // Name = "Bob", Level = 3
            Goblin1 g4 = new Goblin1(3, "Bob");

            Console.WriteLine($"Goblin 1 - Level:  {g1.Level}, Name:  {g1.Name}");
            Console.WriteLine($"Goblin 2 - Level:  {g2.Level}, Name:  {g2.Name}");
            Console.WriteLine($"Goblin 3 - Level:  {g3.Level}, Name:  {g3.Name}");
            Console.WriteLine($"Goblin 4 - Level:  {g4.Level}, Name:  {g4.Name}");

        }

        static void PartialPersonClass()
        {
            //Person person = new Person { Name = "Jasnah", Age = 37, City = "Alethi" };
            //Console.WriteLine($"Name:  {person.Name} | Age: {person.Age} | City: {person.City}");
        }

        static void PlayWithMonsters()
        {
            //bring back a random monster class
            Creature monster = new Creature();
            monster = MonsterGenerator.GenerateMonster();
            Console.WriteLine($"Monster: {monster}, Level:  {monster.Level}\n");

            //how come the drinking is in reverse order of how we added the potions?
            //how come the Troll has 3 more points?
            Console.WriteLine($"A Goblin drinking!!");
            Goblin goblin = new Goblin();
            goblin.AddPotion(new BubblyPotion());
            goblin.AddPotion(new HealingPotion());
            goblin.AddPotion(new PoisonPotion());
            goblin.Drink();
            goblin.Drink();
            goblin.Drink();
            goblin.Regen();

            Console.WriteLine($"A Troll drinking!!");
            Troll troll = new Troll();
            troll.AddPotion(new BubblyPotion());
            troll.AddPotion(new HealingPotion());
            troll.AddPotion(new PoisonPotion());
            troll.Drink();
            troll.Drink();
            troll.Drink();
            troll.Regen();


        }
    }
}
