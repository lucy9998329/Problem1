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

          /*int number = 0;
          int counter = 10;



          for (int i = 0; i < counter; i++){
            
            Console.WriteLine("Please enter a number");
            int input = int.Parse(Console.ReadLine());

            number += input;

          }

          Console.WriteLine($"Total is {number} ");
          Console.WriteLine($"Avarage is {number / 10}");*/

          /*var number = 0;
          var counter = 10;



          for (int i = 0; i < counter; i++){
            
            Console.WriteLine("Please enter a number");
            var isNumber = int.TryParse(Console.ReadLine(), out int input);

            number += input;

          }

          Console.WriteLine($"Total is {number} ");
          Console.WriteLine($"Avarage is {number / counter}");*/

          var number = 0;
          Console.WriteLine("Do you want to add a number?");
          var answer = true;
          var isNumber = bool.TryParse(Console.ReadLine(), out answer);

          if (answer == true)





          
          //End the program with blank line and instructions
          Console.ResetColor();
          Console.WriteLine();
          Console.WriteLine("Press <Enter> to quit the program");
          Console.ReadKey();

            
        }
    }
}
