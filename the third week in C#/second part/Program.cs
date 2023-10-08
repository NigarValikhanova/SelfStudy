namespace Codes_of_Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList, SortedList, Stack, Queue, Hashtable
            //ArrayList arrayList = new ArrayList(); //FIFO
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add("Hellooo");
            //arrayList.Remove(4);

            //foreach (var item in arrayList) 
            //{
            //    Console.WriteLine(item);
            //}

            //Stack myStack = new Stack(); // LIFO
            //myStack.Push(1);
            //myStack.Push(2);
            //myStack.Push(3);
            //myStack.Push(4);
            //myStack.Push(5);
            //myStack.Push("Hello World!");
            //Console.WriteLine(myStack.Count + " count");
            //Console.WriteLine(myStack.Pop() + " deleted"); //sildiyini gosterir
            //Console.WriteLine(myStack.Pop() + " deleted");


            //foreach (var item in myStack)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue queue = new Queue(); //FIFO
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //Console.WriteLine(queue.Dequeue() + " silindi");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item + " elementler");
            //}

            //Hashtable ht = new Hashtable(); //LIFO
            //ht.Add(1, "Resad");
            //ht.Add(2, "Nasir");
            //ht.Add(3, "Ilkin");
            //ht.Add(4, "Ehliman");
            //ht.Add(5, "Elxan");
            //ht.Add(6, "Ilkin");
            //Console.WriteLine(ht.ContainsKey(10)); // like a true and false, It calls values in order to keys.
            //Console.WriteLine(ht[0]);// index yerine key olur burda
            //foreach (var item in ht.Values)
            //{
            //    Console.WriteLine(item);
            //}
            //SortedList ht = new SortedList(); //Sorted
            //ht.Add(1, "Resad");
            //ht.Add(2, "Nasir");
            //ht.Add(3, "Ilkin");
            //ht.Add(4, "Ehliman");
            //ht.Add(5, "Elxan");
            //ht.Add(6, "Ilkin");
            //ht.Remove(5);
            //foreach(var item in ht.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Methods
            //Calc(8, 15, "*");
            //Calc(52, 4, "/");


            while (true)
            {
                Console.Write("Enter a number: ");
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter an operator: ");
                string ope = Console.ReadLine();
                Calc(x1, x2, ope);
            }

            //for (; ; )
            // {
            //     Console.WriteLine("Hello World!");
            // }
            #endregion

        }


        public static void Calc(int num1, int num2, string operation)
        {
            switch (operation)
            {
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    if (num1 > num2)
                    {
                        Console.WriteLine(num1 - num2);
                    }
                    else
                    {
                        Console.WriteLine(num2 - num1);
                    }
                    break;
                case "/":
                    if (num1 > num2)
                    {
                        Console.WriteLine(num1 / num2);
                    }
                    else
                    {
                        Console.WriteLine(num1 / num2);
                    }
                    break;

                default:
                    Console.WriteLine("Wrong operation");
                    break;

            }
        }
    }
}