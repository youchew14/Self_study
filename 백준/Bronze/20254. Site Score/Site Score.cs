string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

int UR = num[0];
int TR = num[1];
int UO = num[2];
int TO = num[3];

int n = (56 * UR) + (24 * TR) + (14 * UO) + (6 * TO);

Console.WriteLine(n);