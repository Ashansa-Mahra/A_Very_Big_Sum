class Result
{
    public static long VeryBigSum(List<long> ar)
    {
        return ar.Sum();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

        long result = Result.VeryBigSum(ar);

        Console.WriteLine(result);
    }
}
