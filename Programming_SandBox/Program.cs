using System;

namespace Programming_SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks Customer for their fixed cost
            Console.WriteLine("What is your fixed cost?");

            //Obtains fixed cost from customer 
            string FixedCost = Console.ReadLine();

            //Asks for the units produced 
            Console.WriteLine("How many Units are you going to produce?");

            //Obtains units from customer 
            string Units = Console.ReadLine();

            //Parses previous strings to ints and ints to boolean
            int IntFixedCost = int.Parse(FixedCost);
            int IntUnits = int.Parse(Units);
            bool BoolUnits = bool.Parse(Units);
            bool BoolFixedCost = bool.Parse(FixedCost);


            if (BoolFixedCost & BoolUnits == null) 
            {
                Console.WriteLine("Please enter a real value.");
            }
            

            //Average cost is calculated 
            int AverageFixedCost = IntFixedCost / IntUnits;
            //Displayed to customer 
            Console.WriteLine("Average fixed cost = " + AverageFixedCost);


            Console.WriteLine("What is your Average Variable cost?");
            string AVC = Console.ReadLine();
            int IntAVC = int.Parse(AVC);

            int TotalCost = (AverageFixedCost + IntAVC) * IntUnits;
            Console.WriteLine(TotalCost);







            //Converts FixedCost string to int
            //try
            //{
            //    int IntFixedCost = Int32.Parse(FixedCost);
            //    Console.WriteLine(FixedCost);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            ////Converts units string to int
            //try
            //{
            //    int IntUnits = Int32.Parse(Units);
            //    Console.WriteLine(Units);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}
