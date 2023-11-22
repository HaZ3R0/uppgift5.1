using System;
namespace uppgift5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("du ska få skriva in 5 namn");
            string[] namn = new string[5];
            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine("Skriv in ett namn");
                namn[i] = Console.ReadLine();
            }
            Console.WriteLine("Namnen du skrev var");

            foreach (string i in namn)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}