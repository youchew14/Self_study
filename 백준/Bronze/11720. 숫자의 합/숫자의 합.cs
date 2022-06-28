int user = int.Parse(Console.ReadLine());
string num = Console.ReadLine();

int sum = 0;

for (int i = 0; i < user; i++)
{
    sum += (int)num[i] - '0';
}

Console.WriteLine(sum);