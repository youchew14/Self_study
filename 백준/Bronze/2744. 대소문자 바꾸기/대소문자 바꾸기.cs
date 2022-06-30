string user = Console.ReadLine();
char[] seq = new char[user.Length];

for (int i = 0; i < user.Length; i++)
{
    if (Char.IsUpper(user[i])) // 대문자 인가?
    {
        seq[i] = Char.ToLower(user[i]);
    }
    else
    {
        seq[i] = Char.ToUpper(user[i]);
    }
}
Console.WriteLine(string.Join("", seq));