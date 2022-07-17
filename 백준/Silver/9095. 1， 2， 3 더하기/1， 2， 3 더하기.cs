int T = int.Parse(Console.ReadLine());
int[] dp = new int[11];

dp[1] = 1;
dp[2] = 2;
dp[3] = 4;

for (int j = 0; j < T; j ++)
{
    int n = int.Parse(Console.ReadLine());

    for (int i = 4; i <= n; i++)
    {
        dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];
    }
    Console.WriteLine(dp[n]);
}