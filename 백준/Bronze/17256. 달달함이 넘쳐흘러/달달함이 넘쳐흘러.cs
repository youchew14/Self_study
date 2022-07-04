string[] user = Console.ReadLine().Split(' ');
double[] num = Array.ConvertAll(user, double.Parse);

double ax = num[0];
double ay = num[1];
double az = num[2];

string[] user2 = Console.ReadLine().Split(' ');
double[] num2 = Array.ConvertAll(user2, double.Parse);

double cx = num2[0];
double cy = num2[1];
double cz = num2[2];

double bx = cx - az;
double by = Math.Truncate(cy / ay);
double bz = cz - ax;

Console.WriteLine("{0} {1} {2}", bx, by, bz);