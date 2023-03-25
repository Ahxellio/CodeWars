namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoSum(new[] { 1, 2, 3 }, 4).OrderBy(a => a).ToArray());
        }
        public static int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                        return new int[] {i, j};
                }
            }
            return new int[0];
        }
    }
}