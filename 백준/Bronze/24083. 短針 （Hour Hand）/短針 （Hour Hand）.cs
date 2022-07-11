int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

DateTime t = new DateTime(2000, 01, 01, a, 0, 0);
t = t.AddHours(b);

Console.WriteLine(int.Parse(t.ToString("hh")));