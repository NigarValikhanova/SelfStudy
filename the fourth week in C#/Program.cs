namespace My_fourth_week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exception handling
            //try
            //{
            //    Console.Write("Enter a number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter another number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(num1 / num2);
            //}
            //catch
            //{
            //    Console.WriteLine("Error");
            //}
            //Console.ReadLine();
            // exception with telling us what is wrong
            //try
            //{
            //    Console.Write("Enter a number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter another number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(num1 / num2);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Console.ReadLine();

            // type of errors
            //try
            //{
            //    Console.Write("Enter a number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter another number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(num1 / num2);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            #endregion

            #region Classes and Objects
              
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord Of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;

            Console.WriteLine(book2.title);
            Console.ReadLine();
            #endregion
        }
    }
}