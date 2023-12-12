int n = int.Parse(Console.ReadLine());
string[] arr = new string[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Console.ReadLine();
}
string result = string.Join(",", arr);
Console.WriteLine(result);