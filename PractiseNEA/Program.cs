using System;

namespace PractiseNEA
{
    // Your task is to write a taxi quotation system, the user must enter destination, starting point, distance and taxi size
    // The cost of the trip will be calculated by multipliying the miles by the cost per mile of the taxi(based on size).
    // The costs for small, medium and large taxis are stored in the costs.csv file, you will need to read this data from file.
    // If the user enters all fields correctly a quote should be printed to the screen
    
    class Program
    {
        // Structures are composite data types once we have defined one we can use the data type just like we
        // would use a float, string or int
        public struct Taxi
        {
            public string size;
            public string destination;
            public string startPoint;
            public double distance;
            public double cost;
        }
        
        static void Main(string[] args)
        {
            TaxiMenu();
        }

        static void TaxiMenu()
        {
            // Data structure for taxi details.
            Taxi quote;

            string taxiChoice = "";

            // You access a structure by using the variable name followed by a . and then the field
            quote.size = "";
            quote.destination = "";
            quote.startPoint = "";
            quote.distance = 0.00d;
            quote.cost = 0.00d;


            do
            {
                // This option should allow the user to type in a size of Taxi either Small, Medium or Large
                // If a valid size is entered this should be stored in the taxiChoice field of the structure quote.
                Console.WriteLine("1-Enter Taxi Size?");
                // This option should allow the user to enter a destination for the trip, it should be between 2 and 20
                // characters. If a valid destination is entered it should be stored in the destination field of the quote structure.

                Console.WriteLine("2-Enter Destination");
                // This option should allow the user to enter a destination for the trip, it should be between 2 and 20
                // characters. If a valid destination is entered it should be stored in the destination field of the quote structure.
                Console.WriteLine("3-Enter start point");
                // This option should allow the user to enter the distance of the taxi journey. It should be betweeen 1 and 50 miles. 
                // If the distance is valid the value should be stored in the startPoint field of the quote structure.
                Console.WriteLine("4-Enter distance");
                // This should calculate the price of the journey if Size,destination, starting point and distance have been
                // entered correctly. The price is equal to the cost of the taxi per mile multiplied by the distance.
                // The cost of Small, Medium and Large Taxis per mile is stored in the costs text file.
                // You should print out a quote to console or file and clear the quote structure for the next user.
                Console.WriteLine("5-Calculate Price and print quote");
                taxiChoice = Console.ReadLine();

            } while (taxiChoice != "5");



        }
    }
}
