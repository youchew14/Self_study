// kg = a / b 기약 분수로 나타내라.
string[] user = Console.ReadLine().Split(' ');
double[] num = Array.ConvertAll(user, double.Parse);

double a = num[0];
double b = num[1];

Console.WriteLine("{0} {1}", b - a, b);