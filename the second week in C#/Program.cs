using static System.Formats.Asn1.AsnWriter;
using System;

namespace testoverall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region learning variables and types
            //int x = 5;
            //int y = 25;
            //int z = 136;
            //Console.WriteLine(x+y+z);
            //int x, y, z;
            //x = y = z = 100;
            //Console.WriteLine(x + y + z);

            //int mynum = 12;
            //double myDoubleNum = 5.99D;
            //char myLetter = 'D';
            //bool myBool = true;
            //string myText

            //string phrase = "Elephant Academy";
            //Console.WriteLine(phrase.Substring(4));
            //Console.ReadLine();

            #endregion

            #region Calculator

            //Console.WriteLine("Welcome to the Magic Calculator");
            //Console.WriteLine("Please, choose the calculation method");
            //Console.WriteLine("1 - addition, 2 - substraction, 3 - multiplication, 4 - division");

            //int method = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Now, enter the first number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Now, enter the second number");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int result = 0;

            //if (method == 1)
            //{
            //    result = num1 + num2;
            //    Console.WriteLine(result);
            //}
            //else if (method == 2)
            //{ 
            //    if (num1 > num2)
            //    {
            //        result = num1 - num2;
            //        Console.WriteLine(result);
            //    }
            //    else
            //    {
            //        result = num2 - num1;
            //        Console.WriteLine(result);

            //    }
            //}
            //else if (method == 3)
            //{
            //    result = num1 * num2;
            //    Console.WriteLine(result);
            //}
            //else if (method == 4)
            //{

            //    if (num1 > num2)
            //    {
            //        result = num1 / num2;
            //        Console.WriteLine(result);
            //    }
            //    else
            //    {
            //        result = num2 / num1;
            //        Console.WriteLine(result);
            //    }

            //}
            //Console.WriteLine(" Your answer is " + result + ". But work hard and do it yourself");
            //Console.ReadLine();

            #endregion

            #region Addition Calc

            //Console.WriteLine("Ilk reqemi daxil edin");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ikinci reqemi daxil edin");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num1 * num2);
            //Console.ReadLine();
            #endregion

            #region Mad Lib Games

            //String adj1, adj2, noun1, noun2, verb, adv;
            //Console.Write("Enter an adjective: ");
            //adj1 = Console.ReadLine();
            //Console.Write("Enter a noun: ");
            //noun1 = Console.ReadLine();
            //Console.Write("Enter a verb, past tense: ");
            //verb = Console.ReadLine();
            //Console.Write("Enter a adverb: ");
            //adv = Console.ReadLine();
            //Console.Write("Enter another adjective: ");
            //adj2 = Console.ReadLine();
            //Console.Write("Enter another noun: ");
            //noun2 = Console.ReadLine();



            //Console.WriteLine("Today I went to the zoo.");
            //Console.WriteLine($"I saw a(n) {adj1} {noun1} jumping up and down in its tree.");
            //Console.WriteLine($"He {verb} {adv} through the large tunnel that led to its {adj2} {noun2}.");
            //Console.ReadLine();

            #endregion

            #region Arrays
            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            //Console.WriteLine(luckyNumbers[0]);
            //luckyNumbers[4] = 985;

            //Console.WriteLine(luckyNumbers[4]);
            //string[] friends = new string[5];
            //friends[0] = "Jim";
            //friends[1] = "Pam";
            //friends[2] = "Michael";
            //friends[3] = "Toby";
            //friends[4] = "Dwight";
            //friends[5] = "Angela";

            //Console.ReadLine();
            #endregion

            #region method and function

            //SayHi("Mike", 32);
            //SayHi("John", 18);
            //SayHi("Jake", 26);
            //SayHi("Chris", 24);
            //Console.ReadLine();
            //static void SayHi(string name, int age)
            //{
            //    Console.WriteLine("Hello " + name + " you are " + age);
            //}
            #endregion

            #region Return Statement
            //int cubedNumber = cube(5);
            //Console.WriteLine(cubedNumber);

            // or you can use this way
            //Console.WriteLine(cube(5));

            //Console.ReadLine();

            //static int cube(int num)
            //{
            //    int result = num * num * num;
            //    return result;

            #endregion

            #region If statement

            //bool isMale = false;
            //bool isTall = true;

            //if (isMale && isTall)
            //{
            //    Console.WriteLine("You are a tall male");
            //}
            //else if (isMale && !isTall)
            //{
            //    Console.WriteLine("You are a short male");
            //}
            //else if (!isMale && isTall)
            //{
            //    Console.WriteLine("You are not male but you are tall");
            //}
            //else
            //{
            //    Console.WriteLine("You are either not male or not tall");
            //}

            #endregion

            #region more if statement
            //Console.WriteLine(GetMax(20, 10, 40));
            //Console.ReadLine();

            //static int GetMax(int num1, int num2, int num3)
            //{
            //    int result;
            //    if (num1 >= num2 && num1 >= num3)
            //    {
            //        result = num1;
            //    }
            //    else if (num2 >= num1 && num2 > 3)
            //    {
            //        result = num2;
            //    }
            //    else
            //    {
            //        result = num3;
            //    }

            //    return result;
            #endregion
        }

    }
        
    }

}