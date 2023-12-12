int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
int evenSum = 0;
int oddSum = 0;
int sum = 0;
foreach (int num in nums)
{
    if (num % 2 == 0)
    {
       evenSum += num;
    }
}
foreach (int num in nums)
{
    if (num % 2 == 1)
    {
        oddSum += num;
    }
}
sum = evenSum - oddSum;
Console.WriteLine(sum);