public class GuessNumber 
{
    int numberToGuess = Random.Shared.Next(1, 11);
    int playerTottalWin = 0;
    int playerWin = 0;
    int AIwin = 0;

    public void StartGame() 
    {
        Console.WriteLine("Guess the number between 1 and 10");
        Console.WriteLine("You have to win 5 times");
        
        while (true)
        {
            Console.WriteLine($"You have won {playerTottalWin} times");
            GuessingNumber();

            if (playerTottalWin == 5)
            {
                Console.WriteLine("You have won the game!");
                break;
            }
        }
    }

    public void ResetGame() 
    {
        playerWin = 0;
        AIwin = 0;
        numberToGuess = Random.Shared.Next(1, 11);
    }
    public void GuessingNumber()
    {
        Console.Write("Enter your guess: ");
        int guess1 = int.Parse(Console.ReadLine());
        if (guess1 == numberToGuess)
        {
            playerWin++;
            playerTottalWin++;
            Console.WriteLine();
            Console.WriteLine("Congratulations you won");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Wrong guess! Try again");
        }

        if (guess1 != numberToGuess)
        {
            Console.Write("Enter your 2-nd guess: ");
            int guess2 = int.Parse(Console.ReadLine());
            if (guess2 == numberToGuess)
            {
                playerWin++;
                playerTottalWin++;
                Console.WriteLine();
                Console.WriteLine("Congratulations you won");
            }
            else if (guess2 != numberToGuess)
            {
                Console.WriteLine();
                Console.WriteLine($"Wrong guess! The correct number was {numberToGuess}");
                AIwin++;
                Console.WriteLine($"AI has {AIwin} win(s)");
                ResetGame();
            }
        }
     
    }
}
