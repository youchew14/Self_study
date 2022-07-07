double d = double.Parse(Console.ReadLine()); // 가로
double D = double.Parse(Console.ReadLine());// 반지름

double c = d * 2;
double ab = D * 2 * Math.PI;

Console.WriteLine("{0:F6}", c + ab);