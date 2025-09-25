// 作业：随机扔 2 个骰子，直到和为 6 时终止。

namespace ConsoleApp1
{
    class Program
        {
            static void Main(string[] args)
            {
                // Random number generation
                Random numGen = new Random();

                int roll01 = 0;
                int roll02 = 0;
                int attempts = 0;
                
                Console.WriteLine("Press enter to roll");
                
                while ( (roll01 + roll02) != 6 )
                {
                    Console.ReadKey();

                    // Rolling two dices
                    roll01 = numGen.Next(1, 7);
                    roll02  = numGen.Next(1, 7);
                        
                    Console.WriteLine("You rolled: " + roll01 );
                    Console.WriteLine("You rolled: " + roll02 );
                    
                    attempts++;
                }

                // Sum
                Console.WriteLine("You spent "+ attempts +" times rolling a six");
                
                Console.ReadKey();
            }
        }
}
