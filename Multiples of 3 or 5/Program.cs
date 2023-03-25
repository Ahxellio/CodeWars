namespace Multiples_of_3_or_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(10));
        }
        public static int Solution(int value)
        {
            int count = 0;
            if (value < 0) return 0;
            for(int i = 1; i < value; i++)
            {
                if ((i % 5 == 0) || (i % 3 == 0))
                    count += i;
            }
            return count;
        }
    }
}