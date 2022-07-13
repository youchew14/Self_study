int n = int.Parse(Console.ReadLine());
int[] arr = new int[1001];

arr[1] = 1;
arr[3] = 1;
arr[4] = 1;

if (n >= 5)
{
    for (int i = 5; i < n + 1; i++)
    {
        if (Math.Min(arr[i-1], Math.Min(arr[i-3], arr[i-4])) == 1)
        {
            arr[i] = 0;
        }
        else
        {
            arr[i] = 1;
        }
    }
}

if (arr[n] == 0)
{
    Console.WriteLine("CY");
}
else
{
    Console.WriteLine("SK");
}