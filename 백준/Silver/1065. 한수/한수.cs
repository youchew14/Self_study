int num = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 0; i < num; i++)
{
    if (num <= 99)
    {
        sum++; // 최대 99까지
    }
    else
    {
        sum = 99;
        for (int j = 99; j <= num; j++) // 99부터 num 까지
        {
            int hun = j / 100;
            int ten = j / 10 % 10;
            int n = j % 10;

            if (n - ten == ten - hun)
            {
                sum++;
            }
        }
    }
}
Console.WriteLine(sum);