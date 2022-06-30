string[] user = new string[31];
int[] users = new int[31];


for (int i = 0; i < user.Length; i++)
{ 
    try
    {
        int index = int.Parse(Console.ReadLine());
        users[index] = index;
    }
    catch (Exception ex)
    {
        break;
    }

}
for (int i = 1; i < user.Length; i++)
{
    if (users[i].ToString() == "0")
    {
        Console.WriteLine(i);
    }
}