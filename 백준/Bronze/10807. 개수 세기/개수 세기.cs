int num = int.Parse(Console.ReadLine());
string[] user = Console.ReadLine().Split();
int re = int.Parse(Console.ReadLine());

int count = 0;

for (int i = 0; i < num; i++)
{
    if (re == int.Parse(user[i]))
    {
        count++;
    }
}
Console.WriteLine(count);