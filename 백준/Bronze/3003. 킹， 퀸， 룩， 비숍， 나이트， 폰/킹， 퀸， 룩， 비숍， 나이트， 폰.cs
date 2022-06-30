string[] user = Console.ReadLine().Split();
int[] chess = { 1, 1, 2, 2, 2, 8 };

for (int i = 0; i < user.Length; i++)
{
    if (chess[i] != int.Parse(user[i]))
    {
        Console.Write((chess[i] - int.Parse(user[i])) + " ");
    }
    else
    {
        Console.Write(0 + " ");
    }
}