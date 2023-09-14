using System;

class Program
{
    static void Main(string[] args)
    
    {
        // getting percentage from user
        Console.Write("What is your grade percentage" ?);

        // getting the string response
        string response = Console.Readline();

        //converting the string into an integer
        int percent = int.Parse(response);

        //getting the string symbol
        string symbol = "";
    }
    
    // Working with the different perecentages to come up with symbols
        if (percent >=90)
        {
            symbol ="A";
        }

        else if (percent >=80)
        {
            symbol ="B";
        }

         else if (percent >=70)
         {
            symbol ="C";
         }

         else if (percent >=60)
         {
            symbol ="D";
            
         }

         else  
         {
            symbol ="F";
         }

         //printing out the outcomes based on the symbols

         Console.Writeline($"Your grade is {symbol}");

         if (percent >=70)
         {
            Console.Writeline ("You passed!");
         }

         else
         {
            Console.Writeline("Better luck next time!");
         }

        

        
    
}