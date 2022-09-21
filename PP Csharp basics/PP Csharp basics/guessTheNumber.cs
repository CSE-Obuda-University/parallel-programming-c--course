Random random = new Random();
int secretNumber = random.Next(0, 100);
int userInput;

//TODO:
// need to add counter (int)
// need to add counter (time)
do
{
    Console.WriteLine(secretNumber);
    Console.WriteLine("Guess the number");
    userInput = int.Parse(Console.ReadLine());

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