string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse); // 기차속도, 파리속도, 사이의 거리
int f = 0;

f = num[2] / (num[0] * 2);
f = f * num[1];

Console.WriteLine(f); //파리의 이동거리