string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

double re = (num[0] + num[1]) - Math.Sqrt(num[0] * num[0] + num[1] * num[1]);

Console.WriteLine("{0:F6}", re);