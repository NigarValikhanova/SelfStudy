using System.Collections;
using System.Text;

namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region null undefined
            //string data = "salam";
            //data = null;
            //Console.WriteLine(data);

            //int z;
            // undefined                     null
            // has not been assigned         could be assigned
            // typeod undefined              typeof object
            // undefined==null /true         undefined===nul /false
            // == tekce qiymeti yoxlayir     === hem qiymeti ve tipi yoxlayir
            #endregion

            #region parse convert.to, try catch
            // int data  = int.Parse(null);
            //  System.ArgumentNullException: Value cannot be null
            //int data1 = Convert.ToInt32(null); 
            //Console.WriteLine(data1);
            // exception qaytarmir,0 qaytarir
            //int data2 = int.Parse("jsidjsk");
            //var x = "gdfksd";
            //if (x is int)
            //{
            //    int data2 =Convert.ToInt32(x);
            //}
            //try
            //{
            //    int data2 = int.Parse("jsidjsk");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Errorunuz cixdi");
            //}
            //finally
            //{
            //    Console.WriteLine("finally block");
            //}
            #endregion

            #region Params
            // Calc(1, 8, 9, 33, 55, 77, 12, 59);
            #endregion

            #region string vs stringbuilder

            //string testString = "Hello!";
            //testString = testString + " This";
            //testString = testString + " is";
            //testString = testString + " c#";
            //testString = testString + " tutorial";
            //Console.WriteLine(testString);

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Hello!");
            //stringBuilder.Append(" This");
            //stringBuilder.Append(" is");
            //stringBuilder.Append(" c#");
            //stringBuilder.Append(" tutorial");
            //Console.WriteLine(testString);

            #endregion

            #region Ref Out
            //ref
            //int num1 = 15;
            //Console.WriteLine(num1 + " original date");
            //ChangeNumber(ref num1);
            //Console.WriteLine(num1 + " method isledikden sonra num1");
            //out
            //int num2;
            //Console.WriteLine(num2 + " original date"); // original datasi yoxdu
            //ChangeNumber2(out num2);
            //Console.WriteLine(num2 + " method isledikden sonra num1");

            #endregion

            #region Class olmadan object

            //var car1 = new
            //{
            //    Type = "Fiat",
            //    Model = "500",
            //    Color = "white"
            //};            
            //var car2 = new
            //{
            //    Type = "Hyundai",
            //    Model = "ix-35",
            //    Color = "black"
            //};
            //var car31 = new
            //{
            //    Type = "Kia",
            //    Model = "Rio",
            //    Color = "yellow"
            //};

            #endregion

            #region Classli object, List <>
            Car car1 = new Car("Kia", "Orange", "Sedan", 23000);
            //car1.Price = 23000;
            //car1.Model = "Kia";
            //car1.Type = "Sedan";
            //car1.Color = "Orange";

            Car car2 = new Car("BMW", "purple", "Jeap", 54000);
            //car2.Price = 554000;
            //car2.Model = "BMW";
            //car2.Type = "Jeap";
            //car2.Color = "purple";

            //Console.WriteLine(car1.Price);
            //Console.WriteLine(car2.Model);

            Console.WriteLine("Enter a model");
            string model = Console.ReadLine();
            Console.WriteLine("Enter a color");
            string color = Console.ReadLine();
            Console.WriteLine("Enter a type");
            string type = Console.ReadLine();
            Console.WriteLine("Enter a price");
            int price = Convert.ToInt32(Console.ReadLine());
            Car car3 = new Car(model, color, type, price);
            //ArrayList carList = new ArrayList();
            //carList.Add(car1);
            //carList.Add(car2);
            //carList.Add(car3);
            //foreach (Car car in carList)
            //{
            //    Console.WriteLine(car.Model);
            //}

            List<Car> Cars = new List<Car>();
            Cars.Add(car1);
            Cars.Add(car2);
            Cars.Add(car3);
            //foreach (var item in Cars)
            //{
            //    Console.WriteLine(item.Model);
            //}
            Console.WriteLine(Cars[0].Price + " " + Cars[0].Model);
            Console.WriteLine(Cars[2].Price + " " + Cars[2].Type);

            List<int> numbers = new List<int>();
            numbers.Add(263);
            numbers.Add(52);
            numbers.Add(632);
            numbers.Add(485);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            int data3 = numbers[0];
            Console.WriteLine(data3 + " new data");

            #endregion
        }

        public static void Calc(params int[] arr)
        {
            //int result = 0;
            //foreach (var item in arr)
            //{
            //    result += item;
            //}
            //Console.WriteLine(result);
            // another way to sum integers
            Console.WriteLine(arr.Sum());

        }
        public static void ChangeNumber(ref int data)
        {
            data = 100;
        }
        public static void ChangeNumber2(out int data)
        {
            data = 200;
        }

    }

    class Car
    {
        public Car(string aModel, string aColor, string aType, int aPrice)
        {
            Model = aModel;
            Color = aColor;
            Type = aType;
            Price = aPrice;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
    }
}