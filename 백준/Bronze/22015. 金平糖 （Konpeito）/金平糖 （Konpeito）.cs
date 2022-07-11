string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

Array.Sort(num);
int a = num[2] - num[0];
int b = num[2] - num[1];

Console.WriteLine(a + b);