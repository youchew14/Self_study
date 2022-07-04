double user = double.Parse(Console.ReadLine());

double n1 = user - (user * 0.22);
double n2 = user - ((user -(user * 0.80)) * 0.22);

Console.WriteLine("{0} {1}", n1, n2);