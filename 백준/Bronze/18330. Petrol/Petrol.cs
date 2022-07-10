int next = int.Parse(Console.ReadLine());
int liter = int.Parse(Console.ReadLine());

int a = 60 + liter;

if (next <= a)
{
    Console.WriteLine(next * 1500);
}
else
{
    Console.WriteLine(a * 1500 + (next - a) * 3000);
}