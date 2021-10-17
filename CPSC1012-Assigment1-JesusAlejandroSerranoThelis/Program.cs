using System;

namespace CPSC1012_Assigment1_JesusAlejandroSerranoThelis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Purpose: ____________________________________________________
            Inputs: ____________________________________________________
            Outputs: ____________________________________________________
            Algorithm: ____________________________________________________
            ____________________________________________________
            ____________________________________________________
            Test Plan:
            Test Case Test Data Expected Results
            --------- --------- ----------------
            Written by: Jesus Alejandro Serrano Thelis
            Written for: Robbin Law & Michelle Poulin
            Section No: ____________________________________________________
            Last modified: 2021.10.17
            */
            // I do not know what to write on the rest of the spaces. 
            double rWidth = 0; //room width
            double rLength = 0; //room length
            double wWidth = 0; //wall width
            double wHeight = 0; //wall height
            double dWidth = 0; //door width
            double dHeight = 0; //door height
            double cWidth = 0; //closet width
            double cHeight = 0; //closet height
            double bBoard = 0; //baseboard
            double tBboard = 0; //total base board
            double fBbprice = 0;  //
            double Casing = 0; //casing
            double tCasing = 0; //total casting
            double wtCasing = 0; // total casting with waste
            double wArea = 0; //wall area 
            double cArea = 0; //ceiling area
            double pFprice = 0; //paint final price
            double fFprice = 0; //floor final price 
            double waste = 0;
            double bwaste = 0; // Base board waste
            double tbbwaste = 0; // Total Base Board Waste
            double fCprice = 0;
            double tArea = 0;
            string paint = "";
            int floor = 0;

            double Ntotal = 0;
            double GST = 0;
            double total = 0;

            string input = "";

            Console.WriteLine("Welcome to The First Assigment Program !!!!!!");
            Console.WriteLine("To start the program I will need to ask you for some information." +
                              "\n What is the Width of the room ? = ");
            input = Console.ReadLine();
            rWidth = Convert.ToDouble(input);
            Console.WriteLine("What is the Length of the room ? =");
            input = Console.ReadLine();
            rLength = Convert.ToDouble(input);
            Console.WriteLine("What is the Width of the Window ? =");
            input = Console.ReadLine();
            wWidth = Convert.ToDouble(input);
            Console.WriteLine("What is the Height of the Window ? =");
            input = Console.ReadLine();
            wHeight = Convert.ToDouble(input);
            Console.WriteLine("What is the Width of the Door ? = ");
            input = Console.ReadLine();
            dWidth = Convert.ToDouble(input);
            Console.WriteLine("What is the Height of the Door ? = ");
            input = Console.ReadLine();
            dHeight = Convert.ToDouble(input);
            Console.WriteLine("Whta is the Width of the Closet ? = ");
            input = Console.ReadLine();
            cWidth = Convert.ToDouble(input);
            Console.WriteLine("What is the Height of the Closet ? = ");
            input = Console.ReadLine();
            cHeight = Convert.ToDouble(input);
            Console.WriteLine("\nThere is 3 types of pain please choose one of these !!" +
                              "\n B = Basic, P = Premium, D = Deluxe. " +
                              "\n           1. Basic 29.99 / Gallon." +
                              "\n           2.Premium 39.99 / Gallon." +
                              "\n           3. Deluxe 49.99 / Gallon.");
            Console.WriteLine("The paint I would like to use is = ");
            paint = Console.ReadLine();
            Console.WriteLine("\n There is 3 types of flooring please choose one of these !! " +
                              "\n Carpet = 1, Tile = 2, Hardwood = 3." +
                              "\n           1. Carpet 2.75 / square foot " +
                              "\n           2. Tile 3.50 / square foot " +
                              "\n           3. Hardwood 4.85 / square foot");
            Console.WriteLine("The flooring I would like to use is = ");
            input = Console.ReadLine();
            floor = Convert.ToInt32(input);
            Console.WriteLine("Please insert the Price of the Baseboard = ");
            input = Console.ReadLine();
            bBoard = Convert.ToDouble(input);
            Console.WriteLine("Please inser the Price of the Casing = ");
            input = Console.ReadLine();
            Casing = Convert.ToDouble(input);

            wArea = ((rWidth * 8) * 2) + ((rLength * 8) * 2); //total wall area 
            cArea = rWidth * rLength; //ceiling area
            tArea = ((wArea / 300) + (cArea / 200) + .5); //total area for paiting
            tCasing = ((wWidth * 2) + (wHeight * 2)) + (dWidth + (dHeight * 2)) + (cWidth + (cHeight * 2)); //Total castig 
            waste = tCasing * .1;
            wtCasing = tCasing + waste;
            fCprice = wtCasing * Casing; //final casting price 
            tBboard = (rWidth * 2) + (rLength * 2); //Total base board 
            bwaste = tBboard * .1;
            tbbwaste = tBboard + bwaste;
            fBbprice = tbbwaste * bBoard;
            Console.WriteLine("                                     Packing Slip                                  " +
                              "\n***********************************************************************************************************************************");
            Console.WriteLine(wArea + "      ^ft. Wall Area.");
            Console.WriteLine(cArea + "      ^ft. Ceiling area");

            if (paint.Equals("b", StringComparison.OrdinalIgnoreCase))
            {
                switch (floor)
                {
                    case 1:
                        pFprice = tArea * 29.99;
                        fFprice = cArea * 2.75;
                        Math.Round(pFprice);
                        Console.WriteLine("\n");
                        Console.WriteLine(Math.Round(tArea)+ " Gallon(s) Basic Paint @  29.99 = " + Math.Round(pFprice, 2));
                        Console.WriteLine(Math.Round(cArea)+ " ^ft. Tile Floorig @  2.75 = " + fFprice);
                        Console.WriteLine(Math.Round(wtCasing, 2) + "ft. Casing  @ " + Casing , " = " + fCprice);
                        Console.WriteLine(Math.Round(tbbwaste, 2) + " ft. Baseboard  @ " + bBoard + " = " + fBbprice);
                        Ntotal = pFprice + fFprice + fCprice + fBbprice;
                        GST = Ntotal * .05;
                        total = Ntotal + GST;
                        Console.WriteLine("                                    Net total = " + Math.Round(Ntotal, 2));
                        Console.WriteLine("                                    GST   = " + Math.Round(GST, 2));
                        Console.WriteLine("                                    Total  =" + Math.Round(total, 2));
                        break;
                    case 2:
                        pFprice = tArea * 29.99;
                        fFprice = cArea * 3.50;
                        Math.Round(pFprice);
                        Console.WriteLine("\n");
                        Console.WriteLine(Math.Round(tArea) + " Gallon(s) Basic Paint @  29.99 = " + Math.Round(pFprice, 2));
                        Console.WriteLine(Math.Round(cArea) + " ^ft. Tile Floorig @  3.50 = " + fFprice);
                        Console.WriteLine(Math.Round(wtCasing, 2) + "ft. Casing  @ " + Casing, " = " + fCprice);
                        Console.WriteLine(Math.Round(tbbwaste, 2) + " ft. Baseboard  @ " + bBoard + " = " + fBbprice);
                        Ntotal = pFprice + fFprice + fCprice + fBbprice;
                        GST = Ntotal * .05;
                        total = Ntotal + GST;
                        Console.WriteLine("                                    Net total = " + Math.Round(Ntotal, 2));
                        Console.WriteLine("                                    GST   = " + Math.Round(GST, 2));
                        Console.WriteLine("                                    Total  =" + Math.Round(total, 2));
                        break;
                    case 3:
                        pFprice = tArea * 29.99;
                        fFprice = cArea * 4.85;
                        Math.Round(pFprice);
                        Console.WriteLine("\n");
                        Console.WriteLine(Math.Round(tArea) + " Gallon(s) Basic Paint @  29.99 = " + Math.Round(pFprice, 2));
                        Console.WriteLine(Math.Round(cArea) + " ^ft. Tile Floorig @  4.85 = " + fFprice);
                        Console.WriteLine(Math.Round(wtCasing, 2) + "ft. Casing  @ " + Casing, " = " + fCprice);
                        Console.WriteLine(Math.Round(tbbwaste, 2) + " ft. Baseboard  @ " + bBoard + " = " + fBbprice);
                        Ntotal = pFprice + fFprice + fCprice + fBbprice;
                        GST = Ntotal * .05;
                        total = Ntotal + GST;
                        Console.WriteLine("                                    Net total = " + Math.Round(Ntotal, 2));
                        Console.WriteLine("                                    GST   = " + Math.Round(GST, 2));
                        Console.WriteLine("                                    Total  =" + Math.Round(total, 2));
                        break;
                }
            }
            else if (paint.Equals("p", StringComparison.OrdinalIgnoreCase))
            {
                switch (floor)
                {
                    case 1:
                        pFprice = tArea * 39.99;
                        fFprice = cArea * 2.75;
                        Math.Round(pFprice);
                        Console.WriteLine("\n");
                        Console.WriteLine(Math.Round(tArea) + " Gallon(s) Basic Paint @  39.99 = " + Math.Round(pFprice, 2));
                        Console.WriteLine(Math.Round(cArea) + " ^ft. Tile Floorig @  2.75 = " + fFprice);
                        Console.WriteLine(Math.Round(wtCasing, 2) + "ft. Casing  @ " + Casing, " = " + fCprice);
                        Console.WriteLine(Math.Round(tbbwaste, 2) + " ft. Baseboard  @ " + bBoard + " = " + fBbprice);
                        Ntotal = pFprice + fFprice + fCprice + fBbprice;
                        GST = Ntotal * .05;
                        total = Ntotal + GST;
                        Console.WriteLine("                                    Net total = " + Math.Round(Ntotal, 2));
                        Console.WriteLine("                                    GST   = " + Math.Round(GST, 2));
                        Console.WriteLine("                                    Total  =" + Math.Round(total, 2));
                        break;
                    case 2:
                        pFprice = tArea * 39.99;
                        fFprice = cArea * 3.50;
                        Math.Round(pFprice);
                        Console.WriteLine("\n");
                        Console.WriteLine(Math.Round(tArea) + " Gallon(s) Basic Paint @  39.99 = " + Math.Round(pFprice, 2));
                        Console.WriteLine(Math.Round(cArea) + " ^ft. Tile Floorig @  3.50 = " + fFprice);
                        Console.WriteLine(Math.Round(wtCasing, 2) + "ft. Casing  @ " + Casing, " = " + fCprice);
                        Console.WriteLine(Math.Round(tbbwaste, 2) + " ft. Baseboard  @ " + bBoard + " = " + fBbprice);
                        Ntotal = pFprice + fFprice + fCprice + fBbprice;
                        GST = Ntotal * .05;
                        total = Ntotal + GST;
                        Console.WriteLine("                                    Net total = " + Math.Round(Ntotal, 2));
                        Console.WriteLine("                                    GST   = " + Math.Round(GST, 2));
                        Console.WriteLine("                                    Total  =" + Math.Round(total, 2));
                        break;
                    case 3:
                        pFprice = tArea * 39.99;
                        fFprice = cArea * 4.85;
                        Math.Round(pFprice);
                        Console.WriteLine("\n");
                        Console.WriteLine(Math.Round(tArea) + " Gallon(s) Basic Paint @  39.99 = " + Math.Round(pFprice, 2));
                        Console.WriteLine(Math.Round(cArea) + " ^ft. Tile Floorig @  4.85 = " + fFprice);
                        Console.WriteLine(Math.Round(wtCasing, 2) + "ft. Casing  @ " + Casing, " = " + fCprice);
                        Console.WriteLine(Math.Round(tbbwaste, 2) + " ft. Baseboard  @ " + bBoard + " = " + fBbprice);
                        Ntotal = pFprice + fFprice + fCprice + fBbprice;
                        GST = Ntotal * .05;
                        total = Ntotal + GST;
                        Console.WriteLine("                                    Net total = " + Math.Round(Ntotal, 2));
                        Console.WriteLine("                                    GST   = " + Math.Round(GST, 2));
                        Console.WriteLine("                                    Total  =" + Math.Round(total, 2));
                        break;
                }
            }
            else
            {
                switch (floor)
                {
                    case 1:
                        pFprice = tArea * 49.99;
                        fFprice = cArea * 2.75;
                        Math.Round(pFprice);
                        Console.WriteLine("\n");
                        Console.WriteLine(Math.Round(tArea) + " Gallon(s) Basic Paint @  49.99 = " + Math.Round(pFprice, 2));
                        Console.WriteLine(Math.Round(cArea) + " ^ft. Tile Floorig @  2.75 = " + fFprice);
                        Console.WriteLine(Math.Round(wtCasing, 2) + "ft. Casing  @ " + Casing, " = " + fCprice);
                        Console.WriteLine(Math.Round(tbbwaste, 2) + " ft. Baseboard  @ " + bBoard + " = " + fBbprice);
                        Ntotal = pFprice + fFprice + fCprice + fBbprice;
                        GST = Ntotal * .05;
                        total = Ntotal + GST;
                        Console.WriteLine("                                    Net total = " + Math.Round(Ntotal, 2));
                        Console.WriteLine("                                    GST   = " + Math.Round(GST, 2));
                        Console.WriteLine("                                    Total  =" + Math.Round(total, 2));
                        break;
                    case 2:
                        pFprice = tArea * 49.99;
                        fFprice = cArea * 3.50;
                        Math.Round(pFprice);
                        Console.WriteLine("\n");
                        Console.WriteLine(Math.Round(tArea) + " Gallon(s) Basic Paint @  49.99 = " + Math.Round(pFprice, 2));
                        Console.WriteLine(Math.Round(cArea) + " ^ft. Tile Floorig @  3.50 = " + fFprice);
                        Console.WriteLine(Math.Round(wtCasing, 2) + "ft. Casing  @ " + Casing, " = " + fCprice);
                        Console.WriteLine(Math.Round(tbbwaste, 2) + " ft. Baseboard  @ " + bBoard + " = " + fBbprice);
                        Ntotal = pFprice + fFprice + fCprice + fBbprice;
                        GST = Ntotal * .05;
                        total = Ntotal + GST;
                        Console.WriteLine("                                    Net total = " + Math.Round(Ntotal, 2));
                        Console.WriteLine("                                    GST   = " + Math.Round(GST, 2));
                        Console.WriteLine("                                    Total  =" + Math.Round(total, 2));
                        break;
                    case 3:
                        pFprice = tArea * 49.99;
                        fFprice = cArea * 4.85;
                        Math.Round(pFprice);
                        Console.WriteLine("\n");
                        Console.WriteLine(Math.Round(tArea) + " Gallon(s) Basic Paint @  49.99 = " + Math.Round(pFprice, 2));
                        Console.WriteLine(Math.Round(cArea) + " ^ft. Tile Floorig @  4.85 = " + fFprice);
                        Console.WriteLine(Math.Round(wtCasing, 2) + "ft. Casing  @ " + Casing, " = " + fCprice);
                        Console.WriteLine(Math.Round(tbbwaste, 2) + " ft. Baseboard  @ " + bBoard + " = " + fBbprice);
                        Ntotal = pFprice + fFprice + fCprice + fBbprice;
                        GST = Ntotal * .05;
                        total = Ntotal + GST;
                        Console.WriteLine("                                    Net total = " + Math.Round(Ntotal, 2));
                        Console.WriteLine("                                    GST   = " + Math.Round(GST, 2));
                        Console.WriteLine("                                    Total  =" + Math.Round(total, 2));
                        break;
                }
            }
        }
    }
}
