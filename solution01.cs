namespace ConsoleApp1
{
    class Program
        {
            static void Main(string[] args)
            {
                Random numGen = new Random();

                int roll01 = 0;
                int roll02 = 0;
                int attempts = 0;
                
                Console.WriteLine("Press enter to roll");
                
                while ( (roll01 + roll02) != 6 )
                {
                    Console.ReadKey();
                    
                    roll01 = numGen.Next(1, 7);
                    roll02  = numGen.Next(1, 7);
                        
                    Console.WriteLine("You rolled: " + roll01 );
                    Console.WriteLine("You rolled: " + roll02 );
                    
                    attempts++;
                }
                
                Console.WriteLine("You spent "+ attempts +" times rolling a six");
                
                Console.ReadKey();
            }
        }
}
