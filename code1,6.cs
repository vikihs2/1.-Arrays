var n = int.Parse(Console.ReadLine());
var arr = new int[n];
int sum = 0;
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}
foreach (int num in arr) 
{
    sum+= num;
}
Console.WriteLine();
Console.WriteLine(sum);