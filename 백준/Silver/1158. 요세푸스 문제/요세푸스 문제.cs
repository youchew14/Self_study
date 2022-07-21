using System.Text;
using System.Linq;
using System.IO;
using System.Collections.Generic;

StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Queue<int> q = new Queue<int>(Enumerable.Range(1, n[0]));
StringBuilder s = new StringBuilder();
int m = 0;

while(q.Count != 0)
{
    m++;
    if (m % n[1] == 0)
    { 
        var k = q.Dequeue();
        s.Append(k + ", ");
    }
    else
    {
        q.Enqueue(q.Dequeue());
    }
}
s.Remove(s.Length - 2, 2);
sw.WriteLine("<{0}>", s);
sw.Close();