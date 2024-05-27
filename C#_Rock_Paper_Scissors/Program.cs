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
                    Console.WriteLine("\nEnemy Chooses Rock!\n");

                    switch (playerChoice.ToLower())
                    {
                        case "r":
                            Console.WriteLine("\nTie!\n");
                            break;

                        case "p":
                            Console.WriteLine("\nPlayer Wins This Round!\n");
                            playerScore++;
                            break;

                        default:
                            Console.WriteLine("\nEnemy Wins This Round!\n");
                            enemyScore++;
                            break;
                    }
                }
                else if(enemyChoice == 1)
                {
                    Console.WriteLine("\nEnemy Chooses Paper!\n");

                    switch (playerChoice.ToLower())
                    {   case "r":
                            Console.WriteLine("\nEnemy Wins This Round!\n");
                            enemyScore++;
                            break;
                        case "p":
                            Console.WriteLine("\nTie!\n");
                            break;
                        default:
                            Console.WriteLine("\nPlayer Wins This Round!\n");
                            playerScore++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nEnemy Chooses Scissors!\n");

                    switch (playerChoice.ToLower())
                    {   
                        case "r":
                            Console.WriteLine("\nPlayer Wins This Round!\n");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("\nEnemy Wins This Round!\n");
                            enemyScore++;
                            break;
                        default:
                            Console.WriteLine("\nTie!\n");
                            break;
                    }
                }

            }

            if (playerScore == 3)
            {
                Console.WriteLine("\n\nYou win!");
            }
            else
            {
                Console.WriteLine("\n\nYou lose!");
            }
        }
    }
}
