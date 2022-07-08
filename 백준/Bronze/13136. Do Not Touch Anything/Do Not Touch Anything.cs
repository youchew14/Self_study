string[] user = Console.ReadLine().Split(' ');
double[] num = Array.ConvertAll(user, double.Parse);

double x = Math.Ceiling(num[0] / num[2]);
double y = Math.Ceiling(num[1] / num[2]);

Console.WriteLine((long)(x * y));