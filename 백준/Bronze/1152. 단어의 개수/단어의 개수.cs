string[] user = Console.ReadLine().Split(" ");

int count = 0;

for (int i = 0; i < user.Length; i++)
{
    if (user[i] != "")
    {
        count++;
    }
}
Console.WriteLine(count);