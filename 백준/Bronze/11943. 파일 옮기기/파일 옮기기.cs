string[] one = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(one, int.Parse);  // A, O

string[] two = Console.ReadLine().Split(' ');
int[] num2 = Array.ConvertAll(two, int.Parse); // A, O


Console.WriteLine(Math.Min(num[0] + num2[1], num[1] + num2[0]));