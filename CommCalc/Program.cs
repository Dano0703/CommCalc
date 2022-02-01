using System;

namespace CommCalc

{
    public class CommissionCalc
    {
        static void Main()
        {
            int item1Sold;
            int item2Sold;
            int item3Sold;
            int item4Sold;


            Console.WriteLine("Number of Item 1 Sold:");
            item1Sold = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of Item 2 Sold:");
            item2Sold = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of Item 3 Sold:");
            item3Sold = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of Item 4 Sold:");
            item4Sold = Convert.ToInt32(Console.ReadLine());

            BaseCommission cs = new(item1Sold, item2Sold, item3Sold, item4Sold);

            Console.WriteLine("Total Earnings - Plus base pay - equals: {0:C}", cs.Commission());

            Console.ReadLine();

        }
    }
}


