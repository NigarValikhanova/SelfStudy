using System.Net.Mail;

namespace Lesson12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Square
            Square square = new Square();
            square.a = 5;
            square.b = 15;
            square.CalculateSquare();
            //Console.WriteLine(square.sahe);
            //square.sahe = 78; private etdiyimiz field deki datani sahe hissesinde getde return etdikden sonra kod oxunmur..
            Student student = new Student();
            student.FullName = "Elxan";
            student.Email = "elxan@gmail.com";
            Console.WriteLine(student.Email);
            //get hisse olmasa onu tekce set etmek olacaq amma oxumaq olmayacaq
            //set hisse olmasa onu tekce oxumaq olacaq...
            #endregion

            #region Medicine
            //string name = "Paracitamol";
            //double price = 0;
            //if (Validation.NullOrEmpty(name) && Validation.NullOrEmpty(price))
            //{
            //    Medicine medicine1 = new Medicine(name, price);
            //}
            //else if (!Validation.NullOrEmpty(name))
            //{
            //    Console.WriteLine("Null or Empty information");
            //}
            //else if (!Validation.NullOrEmpty(price))
            //{
            //    Console.WriteLine("Price must be different from 0");
            //}
            #endregion

        }
    }
    public class Square
    {
        public int a { get; set; }
        public int b { get; set; }
        public int sahe
        {
            get
            {
                return _sahe;
            }
        }
        private int _sahe;
        public void CalculateSquare()
        {
            _sahe = a * b;
        }
    }
    public class Student
    {
        public string FullName { get; set; }
        private string _email { get; set; }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(value);
                    _email = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);

                }
            }

        }
    }
    public class Medicine
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public Medicine(string aName, double aPrice)
        {
            Name = aName;
            Price = aPrice;
        }
    }
    static class Validation
    {
        public static bool NullOrEmpty(string value)
        {
            if (value.Trim() == null || value.Trim() == "")
            {
                return false;
            }
            return true;
        }
        public static bool NullOrEmpty(double price)
        {
            if (price <= 0)
            {
                return false;
            }
            return true;
        }
        public static bool NullOrEmpty(int count)
        {
            if (count <= 0)
            {
                return false;
            }
            return true;
        }
    }
}