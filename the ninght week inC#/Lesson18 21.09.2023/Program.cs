namespace Lesson18_21._09._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate davam
            ////Action
            //Action<string, byte> action = ScreenDetail;
            //action += (x, y) => Console.WriteLine($"Xos geldiniz {x}, sizin yasiniz {y} kecerlidir");
            //action.Invoke("Nigar", 18);
            //// Action 16a yaxin parametr qebul edir, void olur

            ////Func
            //Func<Person, bool> func = CheckName;
            //func += (Person p) => p.Email.Contains("@"); //lambda
            //func += delegate (Person p) { return p.Country == "Azerbaijan"; }; //anonim
            //// func butun methodlari icra etse de sonuncunun cavabini qaytarir deye bir nece method yaratmaga ehtiyac yoxdu
            ////yield var yenilikdi bir nece cavab qaytarir
            ////multicast delegate bir nece method baglanandi += ile yazilir, single delegate bir method baglanandi
            //// generic delegateler action ve func delegatelerdi

            //Person person = new Person
            //{
            //    Name = "Mina",
            //    Email = "mina.mail.ru",
            //    Country = "Azerbaijan"
            //};
            //Console.WriteLine(func.Invoke(person));
            ////bu cur de yaratmaq olar
            //func(new Person
            //{
            //    Name = "Mina",
            //    Email = "mina.mail.ru",
            //    Country = "Azerbaijan"
            //});
            #endregion

            #region Event
            // event delegate bir birine bagli isleyir. Delegate olmasa event yaratmaq olmaz
            ATM atm = new ATM(1500);
            atm.BalanceFinished += (x, y) => { Console.WriteLine($"ATM-de {x} AZN meblegde pul yoxdur. Balans {y}"); };

            atm.BalanceFinished += (x, y) => { Console.WriteLine($"Hormetli musteri balansinizde {x} AZN meblegde pul yoxdur."); };
            atm.TransferSuccessful += (x, y, time) => { Console.WriteLine($"{time} tarixinde {x} AZN meblegde emeliyyat ugurla basa catdi. Balans {y} AZN"); };
            atm.WithDraw(500);
            atm.WithDraw(800);
            atm.WithDraw(200);
            atm.WithDraw(200);
            
            #endregion

        }
        public static void ScreenDetail(string name, byte age)
        {
            Console.WriteLine($"adiniz: {name}, yasiniz {age}");
        }
        public static bool CheckName(Person person)
        {
            if (person.Name.Length >= 3)
            {
                return true;
            }
            return false;
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }

    }
    class ATM
    {
        public event Action<double, double> BalanceFinished;
        public event Action<double, double, DateTime> TransferSuccessful;

        private double _balance;
        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public ATM(double balance)
        {
            Balance = balance;
        }
        // delegate i invoke etmezden once yoxlamaq lazimdi ki delegate e method baglanib ya yox
        public void WithDraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                if (TransferSuccessful != null) //yoxlamani burda apardiq
                {
                    TransferSuccessful.Invoke(amount, Balance, DateTime.Now);
                }
                //file a yazdir bunu sonra
            }
            else
            {
                if (BalanceFinished != null)
                {
                    BalanceFinished.Invoke(amount, Balance);
                }
            }
        }
    }
}