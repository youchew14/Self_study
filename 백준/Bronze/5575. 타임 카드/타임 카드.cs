string[] time = new string[3];

for (int i = 0; i < 3; i++)
{
    string[] user = Console.ReadLine().Split(' ');
    int[] num = Array.ConvertAll(user, int.Parse);

    DateTime tt = new DateTime(1000, 1, 1, num[3], num[4], num[5]);

    tt = tt.AddHours(-num[0]);
    tt = tt.AddMinutes(-num[1]);
    tt = tt.AddSeconds(-num[2]);

    time[i] = tt.ToString("H m s");
}
Console.WriteLine(string.Join("\n", time));