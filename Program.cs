using RockPaperScissors.Utils;

GameChecks gameCheck = new();
Random random = new();

string[] choices = ["rock", "paper", "scissors"];

Console.WriteLine("Lets play Rock, Paper, Scissors...");
Console.WriteLine("Please type in your choice");

int playerChoice;
do
{
    string? input = Console.ReadLine()?.ToLower();
    playerChoice = Array.IndexOf(choices, input);

    if (playerChoice == -1)
    {
        Console.WriteLine("Oops! Please type in Rock, Paper, or Scissors");
    }
} while (playerChoice == -1);

int computerChoice = random.Next(0, 3);
string result = GameChecks.CheckWin(playerChoice, computerChoice);

Console.WriteLine($"You chose {choices[playerChoice]}");
Console.WriteLine($"The computer chose {choices[computerChoice]}");
Console.WriteLine(result);

