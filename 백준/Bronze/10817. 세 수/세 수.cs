string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

Array.Sort(num);
Console.WriteLine(num[1]);