string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse); //D H M

int com = (11 * 24 * 60) + (11 * 60) + 11;
int comd = (num[0] * 24 * 60) + (num[1] * 60) + num[2];

if(comd - com < 0)
{
    Console.WriteLine(-1);
}
else
{
    Console.WriteLine(comd - com);
}