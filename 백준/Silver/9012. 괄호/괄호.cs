StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(sr.ReadLine());

for (int i = 0; i < n; i++)
{
    string s = sr.ReadLine();

    Stack<char> st = new Stack<char>();
    bool re = true;

    for (int j = 0; j < s.Length; j++)
    {
        if (s[j] == '(') st.Push(s[j]);
        else
        {
            if (st.Count != 0) st.Pop();
            else
            {
                re = false;
                break;
            }
        }
    }
    if (st.Count != 0) re = false;

    if (re)
    {
        sw.WriteLine("YES");
    }
    else
    {
        sw.WriteLine("NO");
    }
}
sr.Close();
sw.Close();