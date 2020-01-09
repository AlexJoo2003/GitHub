using System;

namespace GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password: ");
            string passw = Console.ReadLine();
            while (passw != "1234"){
                print("Wrong");
            }
            Console.WriteLine("Correct!");
        }
    }
}
