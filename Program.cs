namespace Topic_8._5___Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word, displayWord, guess;
            int incorrect;
            bool match = false;
            List<string> lettersGuessed = new List<string>();

            word = "COMPUTER";
            displayWord = "________";
            incorrect = 0;

            Console.WriteLine("I want to play a game");
            Console.WriteLine("A game of hangman to be exact");
            Console.WriteLine($"You know the rules: There is a secret word, in this case {word.Length} letters long, and you must guess one letter at a time to figure it out");
            Console.WriteLine("Unlike normal hangman, you only get three wrong guesses before you lose. Let's begin");

            while (incorrect < 3 && match == false)
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

                Console.WriteLine($"Current known letters: {displayWord}");
                Console.WriteLine();
                Console.WriteLine("Current guessed letters:");

                foreach (string letter in lettersGuessed)
                {
                    Console.Write(letter + ", ");
                }

                Console.WriteLine();
                Console.WriteLine($"You have {3 - incorrect} incorrect guesses left");
                Console.WriteLine();
                Console.WriteLine("What letter would you like to guess:");
                guess = Console.ReadLine().ToUpper().Trim();
                
                while (guess.Length > 1 || lettersGuessed.Contains(guess))
                {
                    Console.WriteLine("I'm sorry, please restrict your guesses to one character at a time and esure you haven't already guessed it");
                    guess = Console.ReadLine().ToUpper().Trim();
                }

                if(word.Contains(guess))
                {

                }
                else
                {
                    Console.WriteLine($"The letter {guess} is not contained within the word.");
                    incorrect++;
                    lettersGuessed.Add(guess);
                    Console.ReadLine();
                    Console.Clear();
                }

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
            Console.WriteLine("  +---+");
            Console.WriteLine("  |   |");
            Console.WriteLine("  O   |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("=========");
        }

        public static void TwoIncorrect() 
        {
            Console.WriteLine("  +---+");
            Console.WriteLine("  |   |");
            Console.WriteLine("  O   |");
            Console.WriteLine(" /|\\  |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("=========");
        }

        public static void ThreeIncorrect()
        {
            Console.WriteLine("  +---+");
            Console.WriteLine("  |   |");
            Console.WriteLine("  O   |");
            Console.WriteLine(" /|\\  |");
            Console.WriteLine(" / \\  |");
            Console.WriteLine("      |");
            Console.WriteLine("=========");
        }
    }
}