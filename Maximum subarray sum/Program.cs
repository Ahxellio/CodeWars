namespace Maximum_subarray_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }
        public static int MaxSequence(int[] arr)
        {
            int sum = 0;
            int maxSum = 0;
            foreach (int i in arr)
            {
                if(sum < 0) { sum = 0; }
                sum += i;
                if(sum > maxSum) { maxSum = sum; }
            }
            return maxSum;
        }
    }
}