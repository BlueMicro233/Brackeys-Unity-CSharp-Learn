using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();
            
            shoppingList.Add("Half-Life");
            shoppingList.Add("Grand Theft Auto");
            shoppingList.Add("Red Dead Redemption");
            shoppingList.Add("SenrenBanka");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }
            
            shoppingList.Remove("SenrenBanka");
            shoppingList.RemoveAt(0);
            
            Console.WriteLine("----------------");
            
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }
            
            Console.ReadKey();
        }
    }
}
