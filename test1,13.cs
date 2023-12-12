int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
int num = int.Parse(Console.ReadLine());
bool foundPair = false;
for (int i = 0; i < nums.Length; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] + nums[j] == num)
        {
            Console.WriteLine($"{nums[i]} { nums[j]}");
        }
    }
}