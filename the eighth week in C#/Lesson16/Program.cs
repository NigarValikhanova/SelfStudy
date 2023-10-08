using System;
using System.Collections;
using System.ComponentModel;

namespace Lesson16_13._09._2023
{
    internal class Program
    {
        public delegate bool Checkers(int a);
        public delegate void CheckPerson(Person person);
        // methodu methoda parametr kimi oturur
        //eyni return type da eyni qeder parametr olmalidir
        static void Main(string[] args)
        {
            #region Method with name
            //Console.WriteLine(Sum(5,9,6,3,7,8));
            //Sum(IsEven, 2, 58, 96, 65, 34, 17, 25);
            //Sum(IsDivideByThree, 2, 58, 96, 65, 34, 17, 25);
            //Sum(IsDivideByFive, 2, 58, 96, 65, 34, 17, 25);
            #endregion

            #region Lambda expression
            //Sum(a => a % 2 == 0, 59, 7, 3, 6, 9, 18);
            //Sum(a => a % 2 == 1, 59, 7, 3, 6, 9, 18);
            //// .Netde demek olar ki butun methodlar bu terzde olur
            #endregion

            #region Anonymous method
            //Sum(delegate (int c) { return c % 2 == 0; }, 11, 13, 18, 20, 65);
            //// sadece delegate ile isleyir, tekde islenmir
            #endregion

            #region Delegate
            //// sum methoda gondermeden yoxlamalar aparmaq ucun edirik
            //Checkers checkers = new Checkers(IsEven);
            //checkers += IsDivideByThree;
            //checkers += IsDivideByFive;

            //checkers(24);
            //checkers(15);

            //IsEven(5);
            //IsDivideByThree(5);
            //IsDivideByFive(5);

            //IsEven(15);
            //IsDivideByThree(15);
            //IsDivideByFive(15);
            //// dynamic tiple object tipin esas ferqi runtime ve compile time meselesidi.
            //// dynamic compiletime da tipini bilmir, runtime da bilir. Object compiletime da bilir.

            #endregion

            #region Delegate with string
            Person person = new Person();
            person.Name = "Nigar";
            person.Country = "Azerbaijan";

            CheckPerson checkPerson = new CheckPerson(CheckName);
            checkPerson += delegate (Person c) { Console.WriteLine(c.Country.ToLower() == "azerbaijan" ? "Beli" : "Xeyr"); };
            checkPerson += p => p.Name.Contains("a");
            checkPerson(person);
            #endregion

        }
        #region Method with name send to parameter
        public static bool IsEven(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Cut ededdir");
                return true;
                // return den sonra yazilan kod oxunmur
            }
            Console.WriteLine("Tek ededdir");
            return false;
        }
        public static bool IsDivideByThree(int a)
        {
            if (a % 3 == 0)
            {
                Console.WriteLine("3 e bolunur");
                return true;
            }
            Console.WriteLine("3 e bolunmur");
            return false;
        }
        public static bool IsDivideByFive(int a)
        {
            if (a % 5 == 0)
            {
                Console.WriteLine("5 e bolunur");
                return true;
            }
            Console.WriteLine("5 e bolunmur");
            return false;
        }
        #endregion
        public static int Sum(Checkers check, params int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                if (check(item))
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
            return sum;
        }
        public static void CheckName(Person p)
        {
            if (p.Name.Length > 3)
            {
                Console.WriteLine("3herfden boyukdur");
            }
            else
            {
                Console.WriteLine("Yalnis addir");
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}