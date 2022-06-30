string[] user = Console.ReadLine().Split();
int[] p = new int[user.Length];

for (int i = 0; i < user.Length; i++)
{
    p[i] = int.Parse(user[i]);
}
Console.WriteLine((p[0]*p[1]) + (p[2]*p[3]));