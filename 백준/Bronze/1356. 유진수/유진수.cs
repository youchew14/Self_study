StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

string s = Console.ReadLine();
int[] n1 = new int[s.Length]; // 정방향
int[] n2 = new int[s.Length]; // 역방향

for (int i = 0; i < s.Length; i++)
{
    n1[i] = int.Parse(s[i].ToString());
    n2[i] = int.Parse(s[i].ToString());
}
Array.Reverse(n2);

int num1 = n1.Length;
int num2 = 1;

bool re = false;

while (num1-- > 1)
{
    int[] nn1 = n1[0..num1];
    int[] nn2 = n2[0..num2];

    var data1 = nn1.Aggregate((re1, re2) => re1 * re2);
    var data2 = nn2.Aggregate((re1, re2) => re1 * re2);

    if (data1 == data2)
    {
        re = true;
        break;
    }
    num2++;
}
if (re)
{
    sw.WriteLine("YES");
}
else
{
    sw.WriteLine("NO");
}
sw.Close();