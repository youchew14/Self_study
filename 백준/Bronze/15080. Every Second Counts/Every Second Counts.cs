string[] user = Console.ReadLine().Split(" : ");
int[] num = Array.ConvertAll(user, int.Parse);

string[] user2 = Console.ReadLine().Split(" : ");
int[] num2 = Array.ConvertAll(user2, int.Parse);

DateTime dd = new DateTime(2000, 01, 01, num2[0], num2[1], num2[2]);

dd = dd.AddHours(-num[0]);
dd = dd.AddMinutes(-num[1]);
dd = dd.AddSeconds(-num[2]);

Console.WriteLine((dd.Hour * 60 * 60) + (dd.Minute * 60) + dd.Second);