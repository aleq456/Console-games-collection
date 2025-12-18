class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("GAMES COLLECTION");
        Console.WriteLine("=======================");
        Console.WriteLine("Choose your game:");
        Console.WriteLine("1. Tic-Tac-Toe");
        Console.WriteLine("2. Guess the Number");
        Console.WriteLine("3. Rock-Paper-Scissors");
        Console.WriteLine("4. Dice roll");
        Console.WriteLine("5. Exit");
        Console.WriteLine("=======================");
        Console.Write("Enter your choice (1-5): ");
        var choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            var tictactoe = new TicTacToe();
            tictactoe.StartGame();
        }
        else if (choice == 2)
        {
            var guessNumber = new GuessNumber();
            guessNumber.StartGame();
        }
        else if (choice == 3)
        {
            var rockPaperScissors = new RockPaperScissors();
            while (true)
            {
                rockPaperScissors.StartGame();
            }
        }
        else if (choice == 4)
        {
            var diceRoll = new DiceRoll();
            while (true)
            {
                diceRoll.StartGame();
            }
        }
        else if (choice == 5)
        {
           Console.WriteLine("Exiting the games");
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }
}
