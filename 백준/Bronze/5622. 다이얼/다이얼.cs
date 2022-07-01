string user = Console.ReadLine().ToUpper();
string[] number = { "0", "1", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
int[] sum = new int[10]; // 0 ~ 9
int result = 0;

for (int i = 0; i < user.Length; i++)
{
    for (int j = 0; j < number.Length; j++)
    {
        if (number[j].Contains(user[i].ToString())) //ABC 중에 A가 포함되면 sum ++
        {
            sum[j]++;

        }
    }
}
// 몇 번째 인덱스에 있는지
for (int i = 0; i < sum.Length; i++)
{
    if (sum[i] > 0)
    {
        result += (i + 1) * sum[i];
    }
}
Console.WriteLine(result);