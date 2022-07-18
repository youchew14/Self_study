int n = int.Parse(Console.ReadLine());
Stack<int> s = new Stack<int>();
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

while (n-- > 0)
{
    string[] u = Console.ReadLine().Split(" ");

    if (u[0] == "push")
    {
        s.Push(int.Parse(u[1]));
    }
    else if (u[0] == "size")
    {
        sw.WriteLine(s.Count);
    }
    else if (u[0] == "pop")
    {
        if (s.Count != 0)
        {
            sw.WriteLine(s.Pop());
        }
        else
        {
            sw.WriteLine(-1);
        }
    }
    else if (u[0] == "top")
    {
        if (s.Count != 0)
        {
            sw.WriteLine(s.Peek());
        }
        else
        {
            sw.WriteLine(-1);
        }
    }
    else if (u[0] == "empty")
    {
        if (s.Count != 0)
        {
            sw.WriteLine(0);
        }
        else
        {
            sw.WriteLine(1);
        }
    }
}
sw.Close();