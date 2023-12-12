using System.Linq;
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rotations = int.Parse(Console.ReadLine());
for (int i = 0; i < rotations; i++)
{
   int zeroElement = arr[0];
    for (int j = 0; j <= arr.Length - 2; j++)
    {
        arr[j] = arr[j + 1];
    }
    arr[arr.Length - 1] = zeroElement;
}
Console.WriteLine(String.Join(" ", arr));