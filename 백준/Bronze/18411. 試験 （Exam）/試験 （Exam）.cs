string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

Array.Sort(num);

int n = Math.Max(num[0], num[1]);
int m = Math.Max(num[1], num[2]);

Console.WriteLine(n + m);