int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string user = Console.ReadLine();
    Console.Write((char)user[0]);
    Console.WriteLine((char)user[user.Length-1]);
}