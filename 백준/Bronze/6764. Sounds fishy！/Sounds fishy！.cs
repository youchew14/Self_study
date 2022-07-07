int[] num = new int[4];

for (int i = 0; i < 4; i++)
{
    int user = int.Parse(Console.ReadLine());
    num[i] = user;
}
if (num[0] == num[1] && num[1] == num[2] && num[2] == num[3])
{
    Console.WriteLine("Fish At Constant Depth");
}
else if (num[0] > num[1] && num[1] > num[2] && num[2] > num[3])
{
    Console.WriteLine("Fish Diving");
}
else if (num[0] < num[1] && num[1] < num[2] && num[2] < num[3])
{
    Console.WriteLine("Fish Rising");
}
else
{
    Console.WriteLine("No Fish");
}