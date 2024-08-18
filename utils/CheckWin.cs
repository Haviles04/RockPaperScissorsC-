namespace RockPaperScissors.Utils
{
    public class GameChecks
    {
        public static string CheckWin(int player, int comp)
        {

            bool playerWin = player == 0 && comp != 1 || player == 1 && comp != 2 || player == 2 && comp != 0;

            const string loss = "You lose!";
            const string win = "You win!";

            if (player == comp)
            {
                return "It's a tie!";
            }
            if (playerWin)
                return win;

            return loss;
        }
    }
}