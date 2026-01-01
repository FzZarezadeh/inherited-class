using System;

namespace inherited_class
{
    class grand
    {
        public string name = "";
        public int year = 0;
        public bool marital;
        public string fieldStudy = "";
        public int age;
        public virtual void enterInfo()
        {
            Console.Write("Enter name:");
            name = Console.ReadLine();
            Console.Write("Enter your of year birth:");
            year = int.Parse(Console.ReadLine());
        }

        public void calcAge()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int y = DateTime.Now.Year - year;
            Console.WriteLine("Age of "+name+": "+y);
        }
    }

    class mom : grand
    {
        public override void enterInfo()
        {
            base.enterInfo();
            Console.Write("Are you married? Enter yes or no:");
            marital = Console.ReadLine() == "yes" ? true : false;
        }
    }

    class child : mom
    {
        public override void enterInfo()
        {
            base.enterInfo();
            Console.Write("Enter yoer field of study:");
            fieldStudy = Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            grand one = new grand();
            mom two = new mom();
            child three = new child();

            one.enterInfo();
            Console.WriteLine();
            two.enterInfo();
            Console.WriteLine();
            three.enterInfo();
            Console.WriteLine();

            one.calcAge();
            two.calcAge();
            three.calcAge();


            Console.ReadKey();
        }
    }
}
