string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse); // 시, 분, 초

int second = int.Parse(Console.ReadLine()); // 초단위

DateTime date = new DateTime(2000, 1, 1, num[0], num[1], num[2]);
DateTime date2 = date.AddSeconds(second);
Console.WriteLine(date2.ToString("H m s"));