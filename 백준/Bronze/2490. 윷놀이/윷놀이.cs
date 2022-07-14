for (int k = 0; k < 3; k++)
{
    string[] s = Console.ReadLine().Split();
    int[] n = Array.ConvertAll(s, int.Parse);

    int count = 0;

    for (int j = 0; j < 4; j++)
    {
        if (n[j] == 1)
        {
            count++;
        }
    }
    string[] yut = {"D", "C", "B", "A", "E"};
    Console.WriteLine(yut[count]);
}