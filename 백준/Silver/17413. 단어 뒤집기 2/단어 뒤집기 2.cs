StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

string su = Console.ReadLine();
Stack<char> st = new Stack<char>();

bool re = false;

for (int i = 0; i < su.Length; i++)
{
    if(su[i] == '<')
    {
        re = true;

        while(st.Count != 0)
        {
            sw.Write(st.Pop());
        }
        sw.Write(su[i]);
    }
    else if (su[i] == '>')
    {
        re = false;
        sw.Write(su[i]);
    }
    else if (re)
    {
        sw.Write(su[i]);
    }
    else if (!re)
    {
        if (su[i] == ' ')
        {
            while(st.Count != 0)
            {
                sw.Write(st.Pop());
            }
            sw.Write(su[i]);
        }
        else
        {
            st.Push(su[i]);
        }
    }
}
while(st.Count != 0)
{
    sw.Write(st.Pop());
}
sw.Close();