
namespace my_third_week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region While Loops
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            #endregion

            #region Building a guessing game

            string secretWord = "elephant";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }

            }
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.Write("You Win!");
            }

            #endregion

            #region for loops

            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            for (int n = 0; i < luckyNumbers.Length; n++)
            {
                Console.WriteLine(luckyNumbers[n]);

            }
            #endregion

            #region Building an Exponent Method

            Console.WriteLine(GetPow(4, 3));
            Console.ReadLine();

        }
        static int GetPow(int baseNum, int powNum)
            {
                int result = 1;
                for (int i = 0; i < powNum; i++)
                {
                    result *= baseNum;
                }
                return result;

                #endregion
            }

        }
}