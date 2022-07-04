string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);
int[,] sit = new int[num[0], num[1]];
int h = 0;

for (int i = 0; i < sit.GetLength(0); i++)
{
    for (int j = 0; j < sit.GetLength(1); j++)
    {
        sit[i, j] = h++;
        if (sit[i, j] == num[2])
        {
            Console.WriteLine("{0} {1}", i, j);
        }
    }
}