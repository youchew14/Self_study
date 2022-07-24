StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

string re = "";
int k = 0;

string[] sv = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

for (int i = 0; i < 3; i++)
{
    string s = Console.ReadLine();

    for (int j = 0; j < sv.Length; j++)
    {
        if(s.Contains(sv[j]) && i != 2)
        {
            re += j.ToString();
        }
        else if (s.Contains(sv[j]) && i == 2)
        {
            k = j;
        }
    }
    if (i == 2)
    {
        for (int j = 0; j < k; j++)
        {
            re += 0;
        }
    }
}
sw.WriteLine(long.Parse(re));
sw.Close();