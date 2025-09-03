
int playerScore;
int diceRoll;
playerScore = 0;
diceRoll = 1;
Console.WriteLine("Welcome to Dice Cricket!");
Console.WriteLine("Press Enter to roll the dice.");
Random random = new Random();

while (diceRoll != 5)
{
    if (Console.ReadKey().Key == ConsoleKey.Enter)
    {
        diceRoll = random.Next(1, 7); // random number between 1 and 6
        Console.WriteLine("You rolled:" + diceRoll);
        if (diceRoll != 5)
        {
            playerScore += diceRoll;
            Console.WriteLine("Your current score is:" + playerScore);
        }
    }
    

}

Console.WriteLine("You got out! Your final score is: " + playerScore);
