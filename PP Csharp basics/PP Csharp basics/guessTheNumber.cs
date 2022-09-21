Random random = new Random();
int secretNumber = random.Next(0, 100);
int userInput;
int trial = 5;
int counter = trial;
int timeLimit = 20;
var watch = System.Diagnostics.Stopwatch.StartNew();
double elapsedMs;

Console.WriteLine(secretNumber);
Console.WriteLine("Guess the number");


do
{
    elapsedMs = watch.Elapsed.TotalSeconds;
    Console.WriteLine("Elapsed time: {0} seconds, timeLimit: {1} seconds", elapsedMs, timeLimit);
    Console.WriteLine("Used tiral: {0}, total trials: {1}", trial - counter, trial);

    // handle counter
    if (counter <= 0)
    {
        Console.WriteLine("Game is over (you had only {0} chances)", trial);
        break;
    }
  
    if (elapsedMs > timeLimit)
    {
        Console.WriteLine("Game is over (you had only {0} seconds)", timeLimit);
        break;
    }

    // handle the game logic
    userInput = int.Parse(Console.ReadLine());  // handle possible exception
    counter--;

    if (secretNumber == userInput)
    {
        Console.WriteLine("Found it!");
    }

    else if (secretNumber > userInput)
    {
        Console.WriteLine("Please provide a greater number...");
    }

    else
    {
        Console.WriteLine("Please provide a smaller number...");
    }
}

while (userInput != secretNumber);
watch.Stop();