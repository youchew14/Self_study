string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

double a = num[0]; // 방어율
double b = double.Parse("0." + num[1]); // 방어율 무시 수치 (user)

double re = a*b;

if (a - re >= 100)
{
    Console.WriteLine(0); // 데미지를 줄 수 없음.
}
else
{
    Console.WriteLine(1);
}