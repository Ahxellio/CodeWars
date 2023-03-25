using System.Collections.Immutable;

namespace Highest_Rank_Number_in_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {//10, 7
            //11, 9, 7, 11, 6, 4, 8, 7, 7, 8, 8, 3
            int[] val = { 10, 7 };
            Console.WriteLine(Kata.HighestRank(val)); 
        }
    }
    public class Kata
    {
        public static int HighestRank(int[] arr)
        {
            var dict = arr.OrderBy(k => k).Distinct().ToDictionary(k => k, v => 0);
            foreach (var k in arr) { dict[k]++;  };
            return dict.Aggregate((k, v) => k.Value > v.Value ? k : v).Key;
        }
    }
}