
namespace _07._09._2023_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now.ToString("dddd, dd/MM/yyyy hh:mm:ss"));
            string action = "proqram basladi";
            ConsoleLog consoleLog = new ConsoleLog();
            consoleLog.WriteMethod(action);
            FileLog fileLog = new FileLog();
            fileLog.WriteMethod(action);
        }
    }
    #region Ders izah
    interface Mother
    {
        string Name { get; set; }
        int Test();
    }
    
    interface Father
    {
        int Test2();
    }
    class Child : Mother, Father
    {
        public string Name { get; set; }
        int Mother.Test()
        {
            throw new NotImplementedException();
        }

        int Father.Test2()
        {
            throw new NotImplementedException();
        }
    }
    #endregion
   
    interface ILog
    {
        void WriteMethod (string data);
    }
    class ConsoleLog : ILog
    {
        public void WriteMethod(string data)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss ") + data + "\n";
            Console.WriteLine(date);
        }
    }
    class FileLog : ILog
    {
        public void WriteMethod(string data)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + data + "\n";
            using (StreamWriter file = File.AppendText(@"C:\\Users\\Nigar\\source\\repos\\07.09.2023 Lesson\\bin\\Debug\\log.txt"))
            {
                file.WriteLine(date);
            }
        }
    }
}