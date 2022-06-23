string[] user = Console.ReadLine().Split();
int o = int.Parse(Console.ReadLine());
int h = int.Parse(user[0]);
int m = int.Parse(user[1]);

m = o + m;

while (m >= 60)
{
    h++;
    m -= 60;
}
if (h >= 24)
{
    h -= 24;
}

Console.Write(h + " " + m);