Console.WriteLine("Welcome to the Cool Console App!");

while (true)
{
    Console.WriteLine("\nPlease select an option:");
    Console.WriteLine("1. Generate a random number");
    Console.WriteLine("2. Get the current date and time");
    Console.WriteLine("3. Exit");

    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            GenerateRandomNumber();
            break;
        case "2":
            GetCurrentDateTime();
            break;
        case "3":

            Console.WriteLine("Exiting the Cool Console App. Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

static void GenerateRandomNumber()
{
    Random random = new Random();
    int randomNumber = random.Next(1, 101);
    Console.WriteLine($"Random Number: {randomNumber}");
}

static void GetCurrentDateTime()
{
    DateTime currentDateTime = DateTime.Now;
    Console.WriteLine($"Current Date and Time: {currentDateTime}");
}
