string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

int re = Math.Min((num[1] / num[3]) * (num[2] / num[3]), num[0]);

Console.WriteLine(re);