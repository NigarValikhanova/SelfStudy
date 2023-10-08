namespace Lesson_19_25._09._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fibonacci 
            //dynamic x = 5;
            //object x1 = 5;
            ////compile time basha dushmur ki tipi nedi.
            ////cevirmek asan olur
            //int x2 = x; // hec bir error vermedi
            //// int x3 = x1; // artiq error verir cunki bilir ki object tipdi 
            //Fibonacci_Iterative(24);
            #endregion
            #region EventHandler Delegate
            RegisterUser registeruser = new RegisterUser();
            registeruser.registerUserEvent += EmailVerification;
            registeruser.registerUserEvent += SMSVerification;
            registeruser.RegisterAUser();
            #endregion

        }
        public static void Fibonacci_Iterative(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }

        public static void EmailVerification(object source, EventArgs e)
        {
            Console.WriteLine("Sent Email for Verification");
        }
        public static void SMSVerification(object source, EventArgs e)
        {
            Console.WriteLine("Sent SMS for Verification");
        }
    }
    public class RegisterUser
    {
        public string Name { get; set; }
        public event EventHandler registerUserEvent;
        public void RegisterAUser()
        {
            Console.WriteLine("User registered");
            if (registerUserEvent != null)
            {
                //this -bu classin eventi trigger etmesidir.Yəni bu instance-dan qalxıb event.
                registerUserEvent(this, EventArgs.Empty); // call event
            }
        }
    }
}