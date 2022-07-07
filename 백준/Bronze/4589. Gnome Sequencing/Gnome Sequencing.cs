int user = int.Parse(Console.ReadLine());

Console.WriteLine("Gnomes:");

for (int i = 0; i < user; i++)
{
    string[] user2 = Console.ReadLine().Split(' ');
    int[] num = Array.ConvertAll(user2, int.Parse); // sort
    int[] num2 = Array.ConvertAll(user2, int.Parse); // original

    Array.Sort(num);
    if (num.SequenceEqual(num2))
    {
        Console.WriteLine("Ordered");
    }
    else
    { 
        Array.Reverse(num);
        if (num.SequenceEqual(num2))
        {
            Console.WriteLine("Ordered");
        }
        else
        {
            Console.WriteLine("Unordered");
        }
    }
}