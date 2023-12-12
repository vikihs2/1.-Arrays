int n = int.Parse(Console.ReadLine());
int[] arr1 = new int[n];
int[] arr2 = new int[n];
for (int i = 0; i < n; i++) 
{
    string[] inputLine = Console.ReadLine().Split();
    int num1 = int.Parse(inputLine[0]);
    int num2 = int.Parse(inputLine[1]);
    if (i % 2 == 0)
    {
        arr1[i] = num1;
        arr2[i] = num2;
    }
    else
    {
        arr1[i] = num2;
        arr2[i] = num1;
    }
}
Console.WriteLine(string.Join(" ", arr1));
Console.WriteLine(string.Join(" ", arr2));