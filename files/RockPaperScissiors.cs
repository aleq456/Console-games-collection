class RockPaperScissors
{
    public void StartGame()
    {
        Console.WriteLine("1. Rock");
        Console.WriteLine("2. Paper");
        Console.WriteLine("3. Scissors");
        Console.WriteLine("Choose your move:");
 
        int playerMove = int.Parse(Console.ReadLine());
        int aiMove = Random.Shared.Next(1, 4);

        if (playerMove == aiMove)
        {
            Console.Clear();
            Console.WriteLine("========================It's a tie!========================");
        }
        else if ((playerMove == 1 && aiMove == 3) ||
                 (playerMove == 2 && aiMove == 1) ||
                 (playerMove == 3 && aiMove == 2))
        {
            Console.Clear();
            Console.WriteLine($"========================AI chose {(aiMove == 1 ? "Rock" : aiMove == 2 ? "Paper" : "Scissors")}========================");
            Console.WriteLine("========================You win!========================");
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"========================AI choose {(aiMove == 1 ? "Rock" : aiMove == 2 ? "Paper" : "Scissors")}========================");
            Console.WriteLine("========================AI wins!========================");
        }
    }
}
