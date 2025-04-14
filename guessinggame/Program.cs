void Main()
{
    Random random = new Random();
    int randomInt = random.Next(100);
    int maxAttempts = 0;
    int isCheater = 0;

    Console.WriteLine(@"Welcome to Guessing Game!");
    Console.WriteLine(@"Please choose your difficulty:
    1. Easy
    2. Medium
    3. Hard
    4. Cheater
    ");
    int difficulty = int.Parse(Console.ReadLine());
    switch (difficulty)
    {
        case 1:
            maxAttempts = 8;
            break;
        case 2:
            maxAttempts = 6;
            break;
        case 3:
            maxAttempts = 4;
            break;
        case 4:
            maxAttempts = 1000;
            break;
        default:
            break;
    }

    guessinggame(randomInt, maxAttempts);
}
void guessinggame(int secretNumber, int maxAttempts)
{

    for (int attempt = 0; attempt < maxAttempts; attempt++)
    {
        Console.WriteLine("you have guessed " + attempt + " times you have " + maxAttempts + " attempts");
        Console.Write("Please choose a number between 1 and 100 Enter your guess here:");
        string input = Console.ReadLine();
        bool isValid = int.TryParse(input, out int guess);

        if (!isValid || guess < 1 || guess > 100)
        {
            Console.WriteLine("Invalid input. Restarting your game");
            guessinggame(maxAttempts, maxAttempts);
        }
        if (guess == secretNumber)
        {
            Console.WriteLine("You guessed the secert number!");
            return;
        }
        else if (guess < 1 | guess > 100)
        {
            Console.WriteLine("Choose a number between 1-100.");
        }
        else if (guess > secretNumber)
        {
            Console.WriteLine("You guessed too high.");
        }
        else if (guess < secretNumber)
        {
            Console.WriteLine("You guessed too low");
        }
    }
    Console.WriteLine("You're out of guesses. The secret number was: " + secretNumber);
    return;
}

Main();