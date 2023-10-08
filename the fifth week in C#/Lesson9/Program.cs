using System.Security.Principal;

namespace Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a few updated

            #region previous task1
            //Student student = new Student("Nigar Valikhanova", "A-115", 18);
            //student.GetBirthYear();
            // methodun obyekte bagli olmasini isteyirikse static yazmiriq

            #endregion

            #region previous task2

            Account account1 = new Account("Elgun XXX", "elgun123!");
            Account account2 = new Account("Nigar YYY", "nigar123!");
            Account account3 = new Account("    ", "null123");
            //Console.WriteLine(account1.IDNo);
            //Console.WriteLine(account2.IDNo);

            // Validation
            //string x = "Salam";
            //Validation.IsNullOrEmpty(x);
            //Validation.IsNullOrEmpty(account3.userName);
            //Console.WriteLine(Validation.IsUserNameValid("jsksehfj55"));
            Console.WriteLine(Validation.IsUserNameValid("ELGUN123"));
            Console.WriteLine(Validation.IsPasswordValid("ElGun123"));

            #endregion
            #region Last two tasks
            ArrayList GetStringIndex = new ArrayList { };
            string str = "Dont make people smth";
            Console.WriteLine("Our Word =");
            for (int i = 0; i < str.Length; i++)
            {
                char res = str[i];
                Console.WriteLine(res);

            }
            char indexInside = 'a';
            int findIndex = 0;
            if (findIndex == str.IndexOf(indexInside))
            {
                Console.Write("Element found at the following index: ");
                Console.WriteLine(findIndex);
            }
            else
            {
                Console.WriteLine($"There is not such a/an {indexInside} in this word");
            }
            GetStringIndex.Add(findIndex);

            #endregion

        }
    }
    class Student
    {
        public Student(string aFullName, string aGroupName, byte anAge)
        {
            FullName = aFullName;
            GroupName = aGroupName;
            Age = anAge;

        }
        public string FullName { get; set; }
        public string GroupName { get; set; }
        public byte Age { get; set; }
        public void GetBirthYear()
        {
            int currentYear = DateTime.Now.Year;
            int sBirthYear = currentYear - Age;
            Console.WriteLine(sBirthYear);
        }
    }
    class Account
    {
        public Account(string uname, string pword)
        {
            if (Validation.IsPasswordValid(pword) && Validation.IsUserNameValid(uname))
            {
                No++;
                IDNo = No;
                userName = uname;
                Password = pword;

            }
            else
            {
                Console.WriteLine("Melumatlar duzgun deyil");
            }

        }
        public string userName { get; set; }
        public string Password { get; set; }
        private static int No { get; set; } = 1000;
        public int IDNo { get; set; }


    }
    static class Validation
    {
        public static void IsNullOrEmpty(string data)
        {
            if (!(data.Trim() != "")) // (data == "")
            {
                Console.WriteLine("Sehv yazmisiz bos olmaz");
            }
        }
        public static bool IsUserNameValid(string usrnm)
        {
            bool isDigit = false;
            bool isLetter = false;
            foreach (char item in usrnm)
            {
                // (int)item sadece ascii table-da yerini gosterir
                if ((int)item >= 65 && (int)item <= 90 || (int)item >= 97 && (int)item <= 122)
                {
                    isLetter = true;
                }
                if ((int)item >= 48 && (int)item <= 57)
                {
                    isDigit = true;
                }
                if ((int)item >= 32 && (int)item <= 47)
                {
                    return false;
                }
            }
            if (isDigit == true && isLetter == true)
            {
                return true;
            }
            return false;

        }
        public static bool IsPasswordValid(string pass)
        {
            bool isDigit = false;
            bool isLetter = false;
            bool isSymbol = false;
            if (pass.Length >= 8 && pass.Length <= 25)
            {
                foreach (char item in pass)
                {
                    if ((int)item >= 65 && (int)item <= 90) //boyuk herf
                    {
                        isLetter = true;
                    }
                    if ((int)item >= 48 && (int)item <= 57)
                    {
                        isDigit = true;
                    }
                    if ((int)item >= 32 && (int)item <= 47)
                    {
                        isSymbol = true;
                    }
                }
            }

            if (isDigit == true && isLetter == true && isSymbol == true)
            {
                return true;
            }
            return false;
        }

        // static classin obyekti yaranmir
        // static classin icinde static olmayan hec ne yarada bilmezsen
    }

}
