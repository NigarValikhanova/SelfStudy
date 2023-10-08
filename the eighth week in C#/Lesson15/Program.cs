namespace _11._09._2023_Lesson15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region first
            //Test test = new Test();
            //string x = "";
            //Console.WriteLine(String.IsNullOrEmpty(x));
            //Console.WriteLine(Weeks.Friday);
            #endregion

            #region FileStream

            //// streamWriter
            //// without using
            //FileStream fileStream = new FileStream("C:\\test1.txt", FileMode.Append, FileAccess.Write);
            //StreamWriter streamWriter = new StreamWriter(fileStream);
            //streamWriter.WriteLine("Salam ELgun");
            //streamWriter.WriteLine("Elgun is the best");
            //streamWriter.Close();
            ////with using
            //FileStream fileStream = new FileStream("C:\\test1.txt", FileMode.Append, FileAccess.Write);
            //using(StreamWriter streamWriter = new StreamWriter(fileStream))
            //{
            //    string data = Console.ReadLine();
            //    streamWriter.WriteLine(data);
            //}

            ////StreamReader
            //FileStream fileStream = new FileStream("C:\\test1.txt", FileMode.Open, FileAccess.Read);
            //StreamReader streamReader = new StreamReader(fileStream);
            //streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            //string str = streamReader.ReadToEnd();
            //Console.WriteLine(str);

            #endregion
        }
        enum Weeks
        { 
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday =7
        }
    }
    class Test
    {
        readonly List<Test> tests = new List<Test>(); //ya burda ya da constructorun icinde yaradilmalidi
        readonly int read = 10; //runtime variable
        const int cons = 10; //compile time variable
        public Test()
        {
            read = 100;
            //cons = 100;
            Console.WriteLine($"readonly variable value {read}");
        }
      // classin icinde list tipinde student listi readonly ile vermek olar. Classin ilk obyekti yarananda baslasin 
    }
}