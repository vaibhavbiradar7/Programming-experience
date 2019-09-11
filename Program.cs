

using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many years of experience do you have in professional programming?");
            
            try
            {
                 int years = int.Parse(Console.ReadLine());
            
                    switch (years)
                    {
                        case 0:
                            Console.WriteLine("Need a lot of practice!");
                            Console.WriteLine("Press any key to exit the program ...");
            
                            Console.ReadKey(true);
                            break;
                        case 1:
                            Console.WriteLine("Looks like you have a little experience!");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                        case 2:
                            Console.WriteLine("Wow! You have been doing this for a while!");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                        default:
                            Console.WriteLine("You are an expert!");
                            Console.WriteLine("However, if are here because you did not type an integer value for the number of years - Please enter an integer value next time ...");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                    } 
            } 
            catch
            {
                Console.WriteLine("Please use a decimal data type for your sales amount next time...");
                Console.WriteLine("--- OR ---");
                Console.WriteLine("Please use an integer data type for your number of years in sales next time ...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } 
        } 
    } 
} 
