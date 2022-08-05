StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

string[] s = { "Junior", "Senior" }; //청소년, 성인
while(true)
{
    string[] n = Console.ReadLine().Split();

    if (n[0] == "#") break;
    else if (int.Parse(n[1]) > 17 || int.Parse(n[2]) >= 80)
    {
        sw.WriteLine("{0} {1}", n[0], s[1]);
    }
    else
    {
        sw.WriteLine("{0} {1}", n[0], s[0]);
    }
}
sw.Close();