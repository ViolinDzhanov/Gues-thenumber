Random randomNumber = new Random();
int computerNumber = randomNumber.Next(1, 101);

while (true)
{
    Console.Write("Gues the nimber 1 - 100: ");
    string playerInput = Console.ReadLine();
    bool isValid = int.TryParse(playerInput, out int playernumber);
    if (isValid)
    {
        if (playernumber == computerNumber)
        {
            Console.WriteLine("You guessed it!");
        }
        else if (playernumber > computerNumber)
        {
            Console.WriteLine("Too high!");
        }
        else
        {
            Console.WriteLine("Too low!");
        }
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
}
