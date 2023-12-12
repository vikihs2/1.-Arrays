string[] days = { "M", "Tu", "W", "T", "F", "Sa", "S" };
int day = int.Parse(Console.ReadLine());
if (day >= 1 && day <= 7)
    Console.WriteLine(days[day - 1]);
else
    Console.WriteLine("Invalid day!");