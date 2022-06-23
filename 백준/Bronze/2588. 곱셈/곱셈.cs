string a = Console.ReadLine();
string b = Console.ReadLine();

char[] bc = b.ToCharArray();

Console.WriteLine(int.Parse(a) * int.Parse(bc[2].ToString()));
Console.WriteLine(int.Parse(a) * int.Parse(bc[1].ToString()));
Console.WriteLine(int.Parse(a) * int.Parse(bc[0].ToString()));
Console.WriteLine(int.Parse(a) * int.Parse(b));