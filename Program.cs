
int diceSides = 0;
bool playAgain = true;


while (playAgain)
{
    Console.Write("How many sides do you want for a pair of dice? ");

    while (int.TryParse(Console.ReadLine(), out diceSides) == false || diceSides < 1)
    {  
            Console.WriteLine("Input a number value");     
    }

    Console.WriteLine("Press enter to roll the dice");
    string startRoll = Console.ReadLine();

    int roll1 = RandomNumberGenerator(diceSides);
    int roll2 = RandomNumberGenerator(diceSides);

    Console.WriteLine($"You rolled a {roll1} and a {roll2}!");

    // methods for 6 sided dice
    if (diceSides == 6)
    {
        Console.WriteLine(DiceCombos(roll1, roll2));
        Console.WriteLine(WinOrLose(roll1, roll2));
    }
        
    // loop to go again
    while (true)
    {
        Console.Write("Roll again? (y/n) ");
        string goAgain = Console.ReadLine();

        if (goAgain == "n")
        {
            playAgain = false;
            break;
        } else if (goAgain == "y")
        {
            break;
        } else Console.WriteLine("Not valid answer");
    }
}


// random number generator method
static int RandomNumberGenerator(int dice)
{
    Random rnd = new Random();
    int randomRoll = rnd.Next(1, dice + 1);
    return randomRoll;

}

// six sided dice combos
static string DiceCombos(int dice1, int dice2)
{
    if (dice1 == 1 && dice2 == 1)
    {
        return "Snake Eyes!";
    }
    else if (dice1 == 6 && dice2 == 6)
    {
        return "Box Cars!";
    }
    else if (dice1 + dice2 == 3)
    {
        return "Ace Deuce!";
    }
    else return "";
}

// six sided dice totals
static string WinOrLose(int dice1, int dice2)
{
    if (dice1 + dice2 == 7 || dice1 + dice2 == 11)
    {
        return "Win!";
    } else if (dice1 + dice2 == 2 || dice1 + dice2 == 3 || dice1 + dice2 == 12)
    {
        return "Craps";
    } else return "";
}







