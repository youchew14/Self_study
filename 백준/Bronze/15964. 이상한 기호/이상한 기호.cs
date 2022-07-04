string[] user = Console.ReadLine().Split(' ');
long a = long.Parse(user[0]);
long b = long.Parse(user[1]);

long re = (a + b) * (a - b);

Console.WriteLine(re);