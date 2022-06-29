string[] user = Console.ReadLine().Split();
int result = 0;

for (int i = 0; i < user.Length; i++)
{
    result += int.Parse(user[i]) * int.Parse(user[i]);
}
Console.WriteLine(result%10);