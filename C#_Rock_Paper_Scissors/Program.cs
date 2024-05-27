//Following this tutorial => https://youtu.be/L6-fYpZ1lQc?si=tTlnS2v-4FNu8NSv

namespace C__Rock_Paper_Scissors
{
    //Remove internal from class name
    class Program
    {
        static void Main(string[] args)
        {

            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome to Rock Paper Scissors!");

            while (playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("Player score - " + playerScore + " | Enemy Score - " + enemyScore);
            }
        }
    }
}
