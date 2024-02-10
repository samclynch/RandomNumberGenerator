using System; // Importing the System namespace which contains fundamental types and base classes

class Program
{
    static void Main(string[] args) // The entry point of the program
    {
        Random random = new Random(); // Creating an instance of Random class for generating random numbers
        int numberToGuess = random.Next(1, 101); // Generating a random number between 1 and 100 (inclusive)
        int numberOfTries = 0; // Initializing the variable to count the number of tries
        bool hasGuessedCorrectly = false; // Initializing a boolean variable to track if the guess is correct

        Console.WriteLine("Welcome to the Number Guessing Game!"); // Displaying a welcome message
        Console.WriteLine("I have picked a number between 1 and 100. Try to guess it!"); // Informing the player about the range of numbers

        while (!hasGuessedCorrectly) // Loop until the correct number is guessed
        {
            Console.Write("Enter your guess: "); // Prompting the user to enter their guess
            string input = Console.ReadLine(); // Reading the user's input as a string

            if (int.TryParse(input, out int guess)) // Trying to parse the input string to an integer
            {
                numberOfTries++; // Incrementing the number of tries

                if (guess == numberToGuess) // Checking if the guess is correct
                {
                    hasGuessedCorrectly = true; // Setting the flag to true since the guess is correct
                    Console.WriteLine($"Congratulations! You've guessed the number {numberToGuess} correctly in {numberOfTries} tries."); // Displaying a congratulatory message
                }
                else if (guess < numberToGuess) // Checking if the guess is too low
                {
                    Console.WriteLine("Too low! Try again."); // Informing the user that the guess is too low
                }
                else // If the guess is not correct and not too low, it must be too high
                {
                    Console.WriteLine("Too high! Try again."); // Informing the user that the guess is too high
                }
            }
            else // If the input cannot be parsed to an integer
            {
                Console.WriteLine("Invalid input. Please enter a valid number."); // Informing the user about invalid input
            }
        }

        Console.WriteLine("Thanks for playing!"); // Displaying a farewell message
    }
}
