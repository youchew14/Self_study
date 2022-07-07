int user = int.Parse(Console.ReadLine()); // chiken

string[] user2 = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user2, int.Parse);

int chiken = num[0] / 2 + num[1];

Console.WriteLine(Math.Min(user, chiken));