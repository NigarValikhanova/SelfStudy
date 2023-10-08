namespace _04._09._2023_Lesson13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string ozunu value type kimi aparsa da, reference type a aiddi.
            // Cunki string in ozunun methodlari var
            #region Struct vs Class

            //TestStruct testStruct1 = new TestStruct(5,6) ;
            //testStruct1.Multiply();

            TestStruct testStruct2 = new TestStruct(255,93);
            TestStruct testStruct3 = testStruct2;
            Console.WriteLine(testStruct2.x);
            Console.WriteLine(testStruct3.x);
            testStruct2.x = 7;
            Console.WriteLine(testStruct2.x + " changed");
            Console.WriteLine(testStruct2.y + " changed");

            //TestClass testClass1 = new TestClass(14,368);
            //testClass1.Multiply();

            TestClass testClass = new TestClass(74, 368);
            TestClass testClass2 = testClass;
            Console.WriteLine(testClass.x);
            Console.WriteLine(testClass2.x);
            testClass.x = 91;
            Console.WriteLine(testClass.x + " changed");
            Console.WriteLine(testClass2.x + " changed");
            #endregion
        }
    }
    struct TestStruct 
    {
        public int x;
        public int y;
        public TestStruct(int X, int Y)
        {
            x=X; 
            y=Y;
        }
        public void Multiply ()
        {
            Console.WriteLine(x*y);
        }
        // value type,
        // stackde yerlesir,
        // instance yaradarken new ist olunmur,
        // instance-i structure variable adlanir 
        // classdan suretlidir,
        // hec ne toremir, virtual abstract yoxdur
        // parametrsiz constructor olmur
        // uzvleri default olaraq publicdir
        // kicik data strukturlari ucun ist olunur

    }
    class TestClass 
    {
        public int x;
        public int y;
        public TestClass(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public void Multiply()
        {
            Console.WriteLine(x * y);
        }
        // reference type,
        // heapde yerlesir,
        // instance yaradarken new ist olunur,
        // instance-i object adlanir
        // structdan zeifdi
        // toremesi var, virtual abstract var
        // parametrsiz constructor olur
        // uzvleri default olaraq privatedir
        // kompleks data strukturlari ucun ist olunur

    }
}