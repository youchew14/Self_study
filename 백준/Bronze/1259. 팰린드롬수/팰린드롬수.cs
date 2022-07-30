StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

while(true)
{
    string s = Console.ReadLine();

    int i = 0;
    int j = s.Length - 1;
    bool re = true;

    if (int.Parse(s[0].ToString()) == 0) break;

    for (int k = 0; k < s.Length; k++)
    {
        if (re && int.Parse(s[i].ToString()) == int.Parse(s[j].ToString()))
        {
            i++;
            j--;

            re = true;
        }
        else
        {
            re = false;
        }
    }
    if (re)
    {
        sw.WriteLine("yes");
    }
    else
    {
        sw.WriteLine("no");
    }
}
sw.Close();