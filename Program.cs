using System;

namespace HelloWorld1
{
  class Program
  {
    static void Main(string[] args)
    {
        {
            GreetUser(); // This is a Method
            string name = GetUserInput();// Calling toa method and returning the string value
            DisplayGreeting(name); // Calling to a method by string value
            PerformCalculation();
            DisplayFarewell();

        }

        void GreetUser() { 
            Console.WriteLine("Welcome to the OOP Example Program!"); 
        }

        string GetUserInput() { 
            Console.Write("Enter your name: "); 
            return Console.ReadLine(); 
        }

         void DisplayGreeting(string name)
        {
            string greetingMessage = "Hello, " + name + "!";
            Console.WriteLine(greetingMessage);
        }

         void DisplayFarewell()
        {
            Console.WriteLine("Thank you for using the OOP Example   Program!");
        }

          void PerformCalculation()
        {
            Console.Write("Enter number 1: "); 
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2 : "); 
            int num2 = int.Parse(Console.ReadLine());



            int a = num1; 
            int b = num2; 
            int sum = a + b; 
            Console.WriteLine("The sum of " + a + " and " + b + " is: " + sum);
        }
    }
  }
}