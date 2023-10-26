namespace Topic_8._5___Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word, displayWord;
            int incorrect;
            bool match;

            word = "COMPUTER";
            displayWord = "________";
            incorrect = 0;

            Console.WriteLine("I want to play a game");
            Console.WriteLine("A game of hangman to be exact");
            Console.WriteLine($"You know the rules: There is a secret word, in this case {word.Length} letters long, and you must guess one letter at a time to figure it out");
            Console.WriteLine("Unlike normal hangman, you only get three wrong guesses before you lose. Let's begin");

            while (incorrect < 3)
            {
                if(incorrect == 0)
                {
                    NoIncorrect();
                }
                else if (incorrect == 1)
                {
                    OneIncorrect();
                }
                else if(incorrect == 2)
                {
                    TwoIncorrect();
                }

                Console.ReadLine();
            }

        }

        public static void NoIncorrect()
        {
            Console.WriteLine("  +---+");
            Console.WriteLine("  |   |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("=========");
        }

        public static void OneIncorrect()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void TwoIncorrect() 
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void ThreeIncorrect()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}