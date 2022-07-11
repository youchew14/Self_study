string[] hwn = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(hwn, int.Parse);

int m = Math.Min(num[2] - num[0], Math.Min(num[3] - num[1], Math.Min(num[0], num[1])));

Console.WriteLine(m);