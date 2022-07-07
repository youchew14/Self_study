string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);
string[] p = { "NEWBIE!", "OLDBIE!", "TLE!" };

if (num[1] == 1 || num[1] == 2)
{
    Console.WriteLine(p[0]);
}
else if (num[1] <= num[0])
{
    Console.WriteLine(p[1]);
}
else
{
    Console.WriteLine(p[2]);
}