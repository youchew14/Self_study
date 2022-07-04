string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

int n1 = num[0];
int n2 = num[1];
int n12 = num[2];

int n = (n1 + 1) * (n2 + 1) / (n12 + 1) - 1;

Console.WriteLine(n);