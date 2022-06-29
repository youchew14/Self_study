// 고정 비용 : A
// 가변 비용 : B
// 소비자 가격 : C

string[] user = Console.ReadLine().Split();
long a = int.Parse(user[0]);
long b = int.Parse(user[1]);
long c = int.Parse(user[2]);

int n = 0;
bool point = true;

if (b >= c)
{
    point = false;
    n = -1;
}
while (point)
{
    n++;
    // 총 수입 > 총 비용 = 손익분기점 발생
    if (c * n > a + (b * n))
    {
        //Console.WriteLine("총 수입 : " + (c * n));
        //Console.WriteLine("총 비용 : " + (a + (b * n)));
        break;
    }
}
Console.WriteLine(n);
