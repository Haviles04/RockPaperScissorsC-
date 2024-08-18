namespace RockPaperScissors.Utils
{
    public class GameChecks
    {
        public static string CheckWin(int player, int comp)
        {
            const string loss = "You lose!";
            const string win = "You win!";

            if (player == comp)
            {
                return "It's a tie!";
            }

            switch (player)
            {
                case 0:
                    {
                        if (comp == 1)
                        {
                            return loss;
                        }
                        return win;
                    }
                case 1:
                    {
                        if (comp == 2)
                            return loss;
                    }
                    return win;
                case 2:
                    {
                        if (comp == 0)
                            return loss;
                    }
                    return win;
                default:
                    return "Invalid Move"!;
            }

        }
    }
}