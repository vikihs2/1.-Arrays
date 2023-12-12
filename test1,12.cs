using System.Linq;
string[] names = Console.ReadLine().Split(", ");
string name = Console.ReadLine();
bool inTheTeam = names.Contains(name);
if (inTheTeam)
{
    Console.WriteLine($"{name} is in Team Beyond Reason.");
}
else
{
    Console.WriteLine($"{name} is not in Team Beyond Reason.");
}