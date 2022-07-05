int[] re = new int[5];
int a = 0;

for (int i = 0; i < 5; i++)
{
    re[i] = int.Parse(Console.ReadLine());
    if(re[i] < 40)
    {
        re[i] = 40;
    }
    a += re[i];
}
Console.WriteLine(a / 5);