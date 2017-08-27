using System;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
          //Start the program with Clear();
          Console.Clear();
          
          /*Console.WriteLine("This program will display a number that you type in");
          var number = 0;
          Console.WriteLine("Please type a number");
          var isNumbr = int.TryParse(Console.ReadLine(), out number);
          if (isNumbr){
              Console.WriteLine($"The number is {number}");

          }*/

          int number = 0;
          int counter = 10;



          for (int i = 0; i < counter; i++){
            
            Console.WriteLine("Please enter a number");
            int input = int.Parse(Console.ReadLine());

            number += input;

          }

          Console.WriteLine($"Total is {number} ");
          Console.WriteLine($"Avarage is {number / 10}");



          
          //End the program with blank line and instructions
          Console.ResetColor();
          Console.WriteLine();
          Console.WriteLine("Press <Enter> to quit the program");
          Console.ReadKey();

            
        }
    }
}
