using System.Collections.Generic;
using System.Linq;
using ComputerPartsLibrary;

namespace ComputerPartsApp
{
    public static class Mathematics
    {
        public static readonly string[] lisingMonths = { "6", "9", "12", "15", "18", "24", "36" };
        public static readonly string[] interestPercentages = { "10%", "15%", "25%", "30%" };

        public static Part GetMostExpensivePart(IEnumerable<Part> parts)
        {
            return (from part in parts
                    where part.Price == parts.Max(x => x.Price)
                    select part).Single();
        }

        public static Part GetCheapestPart(IEnumerable<Part> parts)
        {
            return (from part in parts
                    where part.Price == parts.Min(x => x.Price)
                    select part).Single();
        }

        public static decimal GetAveragePrice(IEnumerable<Part> parts) => parts.Average(x => x.Price);

        public static decimal CalculateMedian(IEnumerable<Part> parts)
        {
            var sortedParts = parts.ToList();
            sortedParts.Sort();

            int middle = sortedParts.Count / 2;

            if (sortedParts.Count % 2 != 0) return sortedParts[middle].Price;
            else return (sortedParts[middle].Price + sortedParts[middle - 1].Price) / 2;
        }

        public static double CalculateSimpleInterest(decimal principal, double interest, int time) => (double)principal * (1 + (interest / 100) * time / 12);


    }    
}
