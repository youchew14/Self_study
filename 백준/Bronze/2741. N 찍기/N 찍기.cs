using System.Text;

int n = int.Parse(Console.ReadLine());
StringBuilder num = new StringBuilder();

for (int i = 0; i < n; i++)
{
    num.Append(i + 1 + "\n"); // 문자열로 저장된다.
}
Console.WriteLine(num.ToString());