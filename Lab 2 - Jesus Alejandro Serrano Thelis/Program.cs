using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ffP = "";
            string rrP = "";
            string ddR = "";

            Console.WriteLine("Hello, Welcome to the program \"Should the door activate or should it not ??!!!!\" ");
            Console.WriteLine("True = T , False = F ");
            Console.WriteLine("Is the Front Pad occupied? (T or F) = ");
            ffP = Console.ReadLine();
            string ucaseffP = ffP.ToUpper();
            Console.WriteLine("Is the Rear Pad occupied? (T or F) = ");
            rrP = Console.ReadLine();
            string ucaserrP = rrP.ToUpper();
            Console.WriteLine("Is the Door Open? (T or F) = ");
            ddR = Console.ReadLine();
            string ucaseddR = ddR.ToUpper();

            if (ffP.Equals("t" , StringComparison.OrdinalIgnoreCase))
            {
                if (rrP.Equals("t", StringComparison.OrdinalIgnoreCase))
                {
                    if (ddR.Equals("t", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("The door will be activated ");
                    }
                    else
                    {
                        Console.WriteLine("The door will no be activated");
                    }
                }
                else
                {
                    
                    if (ddR.Equals("t", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("The door will be activated");
                    }
                    else
                    {
                        Console.WriteLine("The door will be activated");
                    }
                }
            }
            else
            {
                if (rrP.Equals("t", StringComparison.OrdinalIgnoreCase))
                {
                    if (ddR.Equals("t", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("The door will be activated");
                    }
                    else
                    {
                        Console.WriteLine("The door will not be activated");
                    }
                }
                else
                {
                    if (ddR.Equals("t", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("The door will not be activated");
                    }
                    else
                    {
                        Console.WriteLine("The door will not be activated");
                    }
                }
            }
        }
    }
}
