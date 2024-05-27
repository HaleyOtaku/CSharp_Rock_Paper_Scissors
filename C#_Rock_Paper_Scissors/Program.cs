//Following this tutorial => https://youtu.be/L6-fYpZ1lQc?si=tTlnS2v-4FNu8NSv

namespace C__Rock_Paper_Scissors
{
    //Remove internal from class name
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome to Rock Paper Scissors!");

            while (playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("Player score - " + playerScore + " | Enemy Score - " + enemyScore);
                Console.WriteLine("Please enter...\n\nr) Rock\np) Paper\nany other letter) Scissors\n\n");
                string playerChoice = Console.ReadLine();

                //Range below is 0-2, because the second value in a Random is exclusive.
                int enemyChoice = random.Next(0,3);

                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy Chooses Rock!");

                    switch (playerChoice.ToLower())
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;

                        case "p":
                            Console.WriteLine("Player Wins This Round!");
                            playerScore++;
                            break;

                        default:
                            Console.WriteLine("Enemy Wins This Round!");
                            enemyScore++;
                            break;
                    }
                }
                else if(enemyChoice == 1)
                {
                    Console.WriteLine("Enemy Chooses Paper!");

                    switch (playerChoice.ToLower())
                    {   case "r":
                            Console.WriteLine("Enemy Wins This Round!");
                            enemyScore++;
                            break;
                        case "p":
                            Console.WriteLine("Tie!");
                            break;
                        default:
                            Console.WriteLine("Player Wins This Round!");
                            playerScore++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enemy Chooses Scissors!");

                    switch (playerChoice.ToLower())
                    {   
                        case "r":
                            Console.WriteLine("Player Wins This Round!");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Enemy Wins This Round!");
                            enemyScore++;
                            break;
                        default:
                            Console.WriteLine("Tie!");
                            break;
                    }
                }

            }
        }
    }
}
