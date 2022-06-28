string word = Console.ReadLine();

for (int i = 97; i < 123; i++)
{
    Console.Write(word.IndexOf(Convert.ToChar(i)) + " ");
}