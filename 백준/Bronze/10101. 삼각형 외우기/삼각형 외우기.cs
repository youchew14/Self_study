int[] re = new int[3];
int a = 0;
string[] round = { "Equilateral", "Isosceles", "Scalene", "Error" };

for (int i = 0; i < 3; i++)
{
    re[i] = int.Parse(Console.ReadLine());
    a += re[i];
}
if (a != 180)
{
    Console.WriteLine(round[3]);
}
else if (re[0] == re[1] && re[1] == re[2])
{
    Console.WriteLine(round[0]);
}
else if (a == 180 && re[0] == re[1] || re[1] == re[2] || re[0] == re[2])
{
    Console.WriteLine(round[1]);
}
else if (a == 180)
{
    Console.WriteLine(round[2]);
}