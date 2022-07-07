int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] user = Console.ReadLine().Split(' ');
    long[] num = Array.ConvertAll(user, long.Parse);

    Console.WriteLine(num[0] + num[1]);
}