while(true)
{
    string user = Console.ReadLine().ToLower();
    if (user == "#") break;

    string[] st = { "a", "e", "i", "o", "u" };
    int count = 0;

    for (int i = 0; i < user.Length; i++)
    {
        for (int j = 0; j < st.Length; j++)
        {
            if (st[j].Contains(user[i]))
            {
                count++;
            }
        }
    }
    Console.WriteLine(count);
}