using System.Text;
using System.IO;

StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(sr.ReadLine());
StringBuilder arr = new StringBuilder();

Stack<int> st = new Stack<int>();
bool re = true;
int c = 1;
st.Push(c);

for (int i = 0; i < n; i++)
{
    int u = int.Parse(sr.ReadLine());
    while (c <= u)
    {
        st.Push(c);
        arr.Append("+");
        arr.Append("\n");
        c++;
    }
    if (st.Peek() == u)
    {
        st.Pop();
        arr.Append("-");
        arr.Append("\n");
    }
    else
    {
        re = false;
        sw.WriteLine("NO");
        break;
    }
}
if (re)
{
    sw.WriteLine(arr);
}
sr.Close();
sw.Close();