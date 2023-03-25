// See https://aka.ms/new-console-template for more information
public class Kata
{
    public static int CountBits(int n)
    {
        string BinaryCode = Convert.ToString(n, 2);
        string count = "";
        foreach (char c in BinaryCode)
        {
            if (c == 49)
                count += c;
        }
        int value = count.Length;
        return value;
    }
    static void Main(string[] args)
    {
        Kata kata = new Kata();
        Console.WriteLine(CountBits(1234));
    }

}
