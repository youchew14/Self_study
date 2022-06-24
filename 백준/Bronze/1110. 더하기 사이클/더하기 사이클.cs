string user = Console.ReadLine();

if (int.Parse(user) <= 9)
{
    user = user + 0;
}

int len = 0;
int num;
int num0 = int.Parse(user);

while (true)
{
    int a = int.Parse(user) / 10;
    int b = int.Parse(user) % 10;
    num = a + b;

    user = b.ToString() + (num % 10).ToString();

    len++;
    if (num0 == int.Parse(user)) break;
}
Console.WriteLine(len);