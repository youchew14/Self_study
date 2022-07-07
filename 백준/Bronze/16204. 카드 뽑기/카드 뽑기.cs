string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

int a = Math.Min(num[1], num[2]) + Math.Min(num[0] - num[1], num[0] - num[2]);

Console.WriteLine(a);