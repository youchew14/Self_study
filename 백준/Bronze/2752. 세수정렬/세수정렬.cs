string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);
Array.Sort(num, 0, num.Length);

Console.WriteLine(string.Join(" ", num));