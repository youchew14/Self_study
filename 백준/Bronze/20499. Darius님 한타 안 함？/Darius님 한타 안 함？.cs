string[] user = Console.ReadLine().Split("/");
int[] num = Array.ConvertAll(user, int.Parse);
string[] p = { "gosu", "hasu" };

if (num[0] + num[2] < num[1] || num[1] == 0)
{
    Console.WriteLine(p[1]);
}
else
{
    Console.WriteLine(p[0]);
}