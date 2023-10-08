namespace Basic_Algorithm_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(TheSum(6, 6));
            //Console.WriteLine(TheSumTest(7, 6));
            //Console.WriteLine(AbsDif(54));
            //Console.WriteLine(AbsDifTest(26));
            //Console.WriteLine(IsThirty(30, 0));
            //Console.WriteLine(IsThirtyTest(25, 52));
            //Console.WriteLine(test(89));
            //Console.WriteLine(IfStatement("else"));
            //Console.WriteLine(RemoveChar("Python", 4));
            //Console.WriteLine(changePostionChar("abcd"));
            //Console.WriteLine(copyFirstLetter("C Sharp"));
            //Console.WriteLine(copyFirstLetter("JS"));
            //Console.WriteLine(giveLastCharBackandEnd("Red"));
            //Console.WriteLine(giveLastCharBackandEnd("Green"));
            //Console.WriteLine(testCopyChar("1"));
            //Console.WriteLine(checkNumbers(37));
            //Console.WriteLine(checkNumbers(3));
            //Console.WriteLine(checkNumbers(14));

        }
        #region Exercise 1
        public static int TheSum(int a, int b)
        {
            if (a == b)
            {
                return (a + b) * 3;
            }
            return a + b;
        }
        public static int TheSumTest(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }
        #endregion

        #region Exercise 2
        public static int AbsDif(int n)
        {
            return n > 51 ? (n - 51) * 3 : 51 - n;
        }
        public static int AbsDifTest(int n)
        {
            const int x = 51;

            if (n > x)
            {
                return (n - x) * 3;
            }
            return x - n;
        }
        #endregion

        #region Exercise 3
        public static bool IsThirty(int a, int b)
        {
            return (a + b) == 30 ? true : false;
        }
        public static bool IsThirtyTest(int x, int y)
        {
            return x == 30 || y == 30 || (x + y == 30);
        }
        #endregion

        #region Exercise 4
        public static bool test(int x)
        {
            if (Math.Abs(x - 100) <= 10 || Math.Abs(x - 200) <= 10)
                return true;
            return false;
            // abs modulunu verir//
        }
        #endregion

        #region Exercise 5
        public static string IfStatement(string x)
        {
            if (x[0] == 'i' && x[1] == 'f')
            {
                return x;
            }
            return "if " + x;
        }
        public static string test(string s)
        {
            if (s.Length > 2 && s.Substring(0, 2).Equals("if"))
            {
                return s;
            }
            return "if " + s;
        }
        #endregion

        #region Exercise 6
        public static string RemoveChar(string str, byte n)
        {
            return str.Remove(n, 1);
        }

        #endregion

        #region Exercise 7

        public static string changePostionChar(string str)
        {
            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }

        #endregion

        #region Exercise 8
        public static string copyFirstLetter(string str)
        {
            if (str.Length < 2)
                return str;
            else return str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);
        }

        #endregion

        #region Exercise 9

        #region my Version
        public static string giveLastCharBackandEnd(string str)
        {
            if (str.Length >= 1)
                return str.Substring(str.Length - 1) + str + str.Substring(str.Length - 1);
            return str;
        }
        #endregion

        #region Comp Version
        public static string testCopyChar(string str)
        {
            var s = str.Substring(str.Length - 1);
            return s + str + s;
        }
        #endregion

        #endregion

        #region Exercise 10

        #region my Version
        public static bool checkNumbers (int n)
        {
            bool isDivideThree = false;
            bool isDivideSeven = false;
            if (n % 3 == 0) 
                isDivideThree = true;
            if (n % 7 == 0)
                isDivideSeven = true;
            if (isDivideSeven || isDivideThree)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Comp Version
        public static bool testCheckNumbers(int n)
        {
            return n % 3 == 0 || n % 7 == 0;
        }
        #endregion

        #endregion
    }
}