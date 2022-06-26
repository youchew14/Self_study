int[] num = new int[10]; // 나머지 값이 들어감.
int count = 0;

bool[] iss = new bool[42];

for (int i = 0; i < num.Length; i++)
{
    num[i] = int.Parse(Console.ReadLine()) % 42;
}
for (int i = 0; i < num.Length; i++)
{
    for (int j = 0; j < 42; j++) // 나머지가 나올 수 있는 최대 값 ( 0 ~ 41 )
    {
        if (num[i] == j)
        {
            iss[j] = true;
        }
    }
}
for (int i = 0; i < iss.Length; i++)
{
    if (iss[i] == true)
    {
        count++;
    }
}

Console.WriteLine(count);