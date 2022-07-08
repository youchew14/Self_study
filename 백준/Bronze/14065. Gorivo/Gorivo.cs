double um = double.Parse(Console.ReadLine());

double m = 1.609344;
double l = 3.785411784;

double g = 100.0 / ((m / l) * um);

Console.WriteLine("{0:F6}", g);