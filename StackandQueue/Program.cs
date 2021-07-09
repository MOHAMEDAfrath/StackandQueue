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
                    while (true)
                    {
                        Console.WriteLine("Stack Operations");
                        Console.WriteLine("1.Push");
                        Console.WriteLine("2.Peek");
                        Console.WriteLine("3.Pop");
                        Console.WriteLine("4.Exit");
                        int soptions = Convert.ToInt32(Console.ReadLine());
                        switch (soptions)
                        {
                            case 1:
                                Console.WriteLine("Push");
                                stackOperations.Push(70);
                                stackOperations.Push(30);
                                stackOperations.Push(56);
                                Console.WriteLine("After pushing:");
                                stackOperations.Display();
                                break;
                            case 2:
                                Console.WriteLine("Peek");
                                stackOperations.Peek();
                                break;
                            case 3:
                                Console.WriteLine("Pop");
                                stackOperations.Pop();
                                Console.WriteLine("After Pop:");
                                stackOperations.Display();
                                break;
                            case 4:
                                return;
                        }
                    }
                    break;
                case 3:
                    return;

            


            }
           

        }
    }
}
