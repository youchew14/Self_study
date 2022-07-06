string day = Console.ReadLine();
string[] car5 = Console.ReadLine().Split();

int count = 0;

for (int i = 0; i < car5.Length; i++)
{
    if (day.Contains(car5[i]))
    {
        count++;
    }
}
Console.WriteLine(count);