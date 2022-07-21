StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(Console.ReadLine());
List<int> list = new List<int>();

while(n-- > 0)
{
    string[] u = Console.ReadLine().Split(" ");

    if (u[0] == "push_back")
    {
        list.Add(int.Parse(u[1]));
    }
    else if(u[0] == "push_front")
    {
        list.Insert(0, int.Parse(u[1]));
    }
    else if (u[0] == "pop_front")
    {
        if(list.Count > 0)
        {
            sw.WriteLine(list[0]);
            list.RemoveAt(0);
        }
        else
        {
            sw.WriteLine(-1);
        }
    }
    else if (u[0] == "pop_back")
    {
        if (list.Count > 0)
        {
            sw.WriteLine(list[list.Count - 1]);
            list.RemoveAt(list.Count - 1);
        }
        else
        {
            sw.WriteLine(-1);
        }
    }
    else if (u[0] == "size")
    {
        sw.WriteLine(list.Count);
    }
    else if (u[0] == "empty")
    {
        if (list.Count > 0)
        {
            sw.WriteLine(0);
        }
        else
        {
            sw.WriteLine(1);
        }
    }
    else if (u[0] == "front")
    {
        if (list.Count > 0)
        {
            sw.WriteLine(list[0]);
        }
        else
        {
            sw.WriteLine(-1);
        }
    }
    else if (u[0] == "back")
    {
        if (list.Count > 0)
        {
            sw.WriteLine(list[list.Count - 1]);
        }
        else
        {
            sw.WriteLine(-1);
        }
    }
}
sw.Close();