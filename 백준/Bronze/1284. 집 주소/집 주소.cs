StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

while(true)
{
    int sum = 2;

    string s = Console.ReadLine();

    if (s == "0") break;

    for (int i = 0; i < s.Length; i++)
    {
        int n = int.Parse(s[i].ToString());

        if (n == 1)
        {
            sum += 2;
        }
        else if (n == 0)
        {
            sum += 4;
        }
        else
        {
            sum += 3;
        }
    }
    sum += s.Length - 1;
    sw.WriteLine(sum);
}
sw.Close();