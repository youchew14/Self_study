string[] user = Console.ReadLine().Split(' ');
double[] num = Array.ConvertAll(user, double.Parse);

double a = num[0];
double b = num[1];

double m = (b - a) / 400;
double re = 1 / (1 + Math.Pow(10, m));

Console.WriteLine(re);