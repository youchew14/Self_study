string tea = Console.ReadLine();

string[] user = Console.ReadLine().Split(' ');
int count = 0;

for (int i = 0; i < 5; i++)
{
    if (tea.Contains(user[i]))
    {
        count++;
    }
}
Console.WriteLine(count);