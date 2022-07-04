int user = int.Parse(Console.ReadLine());
int re = user;

for (int i = 1; i < user; i++)
{
    re = re * (user - i);
}
if (user == 0)
{
    re = 1;
}
Console.WriteLine(re);