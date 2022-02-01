using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommCalc

{
    class BaseCommission
    {
        private const decimal ITEM1 = 239.99M;
        private const decimal ITEM2 = 126.75M;
        private const decimal ITEM3 = 99.95M;
        private const decimal ITEM4 = 350.89M;
        private const decimal PAY_PER_WEEK = 200;
        private const decimal PERCENTAGE = 0.09M;

        public BaseCommission(int item1Sold, int item2Sold, int item3Sold, int item4Sold)
        {
            Item1Sold = item1Sold;
            Item2Sold = item2Sold;
            Item3Sold = item3Sold;
            Item4Sold = item4Sold;
        }

        public int Item1Sold { get; set; }
        public int Item2Sold { get; set; }
        public int Item3Sold { get; set; }
        public int Item4Sold { get; set; }

        public decimal GetTotalSales()
        {
            return ITEM1 * Item1Sold + ITEM2 * Item2Sold + ITEM3 * Item3Sold + ITEM4 * Item4Sold;
        }

        public decimal Commission()
        {
            return GetTotalSales() * PERCENTAGE + PAY_PER_WEEK;
        }
    }
}
