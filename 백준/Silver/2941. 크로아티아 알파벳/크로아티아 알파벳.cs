string user = Console.ReadLine();
string[] croen = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
int count = 0;

for (int j = 0; j < croen.Length; j++)
{
    if (user.Contains(croen[j]))
    {
        user = user.Replace(croen[j], ",");
        count++;
    }
}
Console.WriteLine(user.Length);