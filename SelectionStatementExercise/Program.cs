namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game.");
            Console.WriteLine("Try your luck. How big of a number would you like to try to guess?");
            var range = int.Parse(Console.ReadLine());
            var r = new Random();
            var favNumber = r.Next(1, range);
            int userInput;
            do
            {

                Console.WriteLine($"Ok, you're going to guess a number between 1 and {range}. Enter your guess now: ");

                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"Sorry. Your guess was too small.");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"Sorry. Your guess was too big.");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It was {favNumber}");
                }
            } while (favNumber != userInput);
        }
    }
}
