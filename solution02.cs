using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studentList = new List<string>();
            
            // User controlled list size
            Console.WriteLine("How many students do you want to add?");
            int numStudents = Convert.ToInt32(Console.ReadLine());
            
            // input name counts related to numStudents
            for (int i = 0; i < numStudents; i++)
            {
                studentList.Add(Console.ReadLine());
            }
            
            Console.WriteLine("----------------");
            
            // Sort the student alphabetically by using studentList.Sort();
            studentList.Sort();
            
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine(studentList[i]);
            }
            
            Console.ReadKey();
        }
    }
}
