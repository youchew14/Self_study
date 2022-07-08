int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int o = (b * 2) + (c * 4);
int oo = (a * 2) + (c * 2);
int ooo = (a * 4) + (b * 2);

Console.WriteLine(Math.Min(o, Math.Min(oo, ooo)));