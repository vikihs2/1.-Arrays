string input = Console.ReadLine();
string[] elements = input.Split(' ');
Array.Reverse(elements);
foreach (string element in elements)
{
    Console.WriteLine(element);
}