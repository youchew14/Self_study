string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

string[] user2 = Console.ReadLine().Split(' ');
int[] num2 = Array.ConvertAll(user2, int.Parse);

int a = Math.Max(num[2], num2[2]) - Math.Min(num[0], num2[0]);
int b = Math.Max(num[3], num2[3]) - Math.Min(num[1], num2[1]);
int re = Math.Max(a, b);

Console.WriteLine(re * re);