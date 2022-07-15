int n = int.Parse(Console.ReadLine());
int cute = 0;
int ncute = 0;

for (int i = 0; i < n; i++)
{
    int c = int.Parse(Console.ReadLine());

    if (c == 1)
    {
        cute++;
    }
    else
    {
        ncute++;
    }
}
int min = Math.Min(cute, ncute);

if (min == ncute)
{
    Console.WriteLine("Junhee is cute!");
}
else
{
    Console.WriteLine("Junhee is not cute!");
}