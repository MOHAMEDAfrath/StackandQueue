using System;

namespace StackandQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Problem");
            StackOperations stackOperations = new StackOperations();
            Console.WriteLine("Enter 1 for Stack Operations");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    Console.WriteLine("Push");
                    stackOperations.Push(70);
                    stackOperations.Push(30);
                    stackOperations.Push(56);
                    Console.WriteLine("After pushing:");
                    stackOperations.Display();
                    break;

            }
           

        }
    }
}
