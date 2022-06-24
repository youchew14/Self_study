int[] n = new int[3];
int count = 0;

for (int i = 0; i < n.Length; i++)
{
    // 일단 다 넣고
    n[i] = int.Parse(Console.ReadLine());
}
char[] c = (n[0] * n[1] * n[2]).ToString().ToCharArray();

for (int j = 0; j < 10; j++)
{
    for (int i = 0; i < c.Length; i++)
    {
        if (c[i].ToString() == j.ToString())
        {
            count++;
        }   
    }
    Console.WriteLine(count);
    count = 0;
}