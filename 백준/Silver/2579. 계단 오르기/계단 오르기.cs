using System.IO;

StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(sr.ReadLine());
int[] arr = new int[301];
int[] dp = new int[301];

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(sr.ReadLine());
}
dp[0] = arr[0]; // 움직일 수 없음
dp[1] = Math.Max(arr[0] + arr[1], arr[1]); // 한 칸
dp[2] = Math.Max(arr[0] + arr[2], arr[1] + arr[2]); // 두 칸

for (int i = 3; i < n; i++)
{
    dp[i] = Math.Max(dp[i - 2] + arr[i], arr[i - 1] + arr[i] + dp[i - 3]);
}
sw.WriteLine(dp[n - 1]);

sr.Close();
sw.Close();