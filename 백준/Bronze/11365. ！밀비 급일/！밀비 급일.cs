while(true)
{
    string user = Console.ReadLine();
    if (user == "END") break;
    for (int i = user.Length - 1; i >= 0; i--)
    {
        Console.Write(user[i]);
    }
    Console.WriteLine();
}