string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

int r2 = ( num[1] * 2 ) - num[0];

Console.Write(r2);