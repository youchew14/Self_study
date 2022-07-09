string[] user = Console.ReadLine().Split(' ');
int one = 0;
int two = 0;

for (int i = 0; i < user.Length; i++)
{
    if (user[i].Contains("1"))
    {
        one++;
    }
    else
    {
        two++;
    }
}
if (one > two)
{
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(2);
}