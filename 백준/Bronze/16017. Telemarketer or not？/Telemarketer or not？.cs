int[] num = new int[4];
bool re = false;

for (int i = 0; i < num.Length; i++)
{
    num[i] = int.Parse(Console.ReadLine());
}
if (num[1] == num[2])
{
    if (num[0] == 8 || num[0] == 9)
    {
        if (num[3] == 8 || num[3] == 9)
        {
            re = true;
        }
    }
}
if (re)
{
    Console.WriteLine("ignore");
}
else
{
    Console.WriteLine("answer");
}