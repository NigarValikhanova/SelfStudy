namespace Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer user1 = new Developer("Nigar", "Valikhanova");
            Developer user3 = new Developer("Murad", "Muradov");
            Developer user4 = new Developer("Diana", "Aliyeva");
            user1.Salary = 1500;
            user1.Position = "Junior";
            Console.WriteLine(user1.CalculateBonus());
            user1.TotalSalary =1; //total salaryni constructorda set ni yigisdiranda qiraqdan qiymet vere bilmirik.....
            Console.WriteLine(user1.TotalSalary);
            ////Employee employee = new Employee("hgg", "hjhjfgggh"); // class in adina abstract elave edende obyektini yaratmaq olmur.....
            Accountant accountant = new Accountant("hghgh", "hjghfdgdsd");
            accountant.Position = "Muhasib";
            accountant.Salary = 1000;
            Console.WriteLine(accountant.CalculateBonus());

        }
    }
   public abstract class Employee //base class
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public decimal TotalSalary { get; set; }
        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        //public virtual decimal CalculateBonus()
        //{
        //    decimal bonus = 0;
        //    if (Position == "Junior")
        //    {
        //        bonus = Convert.ToDecimal(Salary * 0.5);
        //    }
        //    else if (Position == "Middle")
        //    {
        //        bonus = Convert.ToDecimal(Salary * 0.75);
        //    }
        //    else if (Position == "Senior")
        //    {
        //        bonus = Convert.ToDecimal(Salary * 1.05);
        //    }
        //    else
        //    {
        //        bonus = 0;
        //    }
        //    TotalSalary = bonus + Salary;
        //    return bonus;
        //}
        // abstract mecburidi, virtual istesek deyise bilerik. Base class in icinde body siz methoddu.


        public abstract decimal CalculateBonus();
    }
    public class Developer:Employee //derived class
    {
        public Developer(string nm, string srnm) : base(nm, srnm) { }
        public string ProgrammingLang { get; set; }
        public void DeveloperCoding()
        {
            Console.WriteLine("Codinggggggg");
        }
        public override decimal CalculateBonus()
        {
            decimal bonus = 0;
            if (Position == "Junior")
            {
                bonus = Convert.ToDecimal(Salary * 0.5);
            }
            else if (Position == "Middle")
            {
                bonus = Convert.ToDecimal(Salary * 0.75);
            }
            else if (Position == "Senior")
            {
                bonus = Convert.ToDecimal(Salary * 1.05);
            }
            else
            {
                bonus = 0;
            }
            TotalSalary = bonus + Salary;
            return bonus;
           
        }
    }
    public class Accountant:Employee //derived class
    {
        public Accountant(string nm, string srnm) : base(nm, srnm) { }
        public override decimal CalculateBonus()
        {
            decimal bonus = 0;
            if (Position == "Muhasib")
            {
                bonus = Convert.ToDecimal(Salary * 0.05);
            }
            else if (Position == "Aparici Muhasib")
            {
                bonus = Convert.ToDecimal(Salary * 0.1);
            }
            TotalSalary = bonus + Salary;
            return bonus;
        }
    }

}