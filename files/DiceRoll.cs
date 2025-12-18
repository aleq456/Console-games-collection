class DiceRoll
{
    public void StartGame()
    {
        Console.WriteLine("Your choice needs to be higher than the Dice roll");
        Console.WriteLine("Enter the your choice 1-12 :");
        var userChoice = int.Parse(Console.ReadLine());
        int diceRoll = new Random().Next(1, 13);
        Console.WriteLine($"The Dice rolled: {diceRoll}");
        Console.WriteLine($"Your choice: {userChoice}");
        if (userChoice > diceRoll)
        {
            Console.WriteLine("You win!");
        }
        else if (userChoice < diceRoll)
        {
            Console.WriteLine("You lose!");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }
}
