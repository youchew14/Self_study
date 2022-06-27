int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    int sum = 0;
    int count = 0;

    string[] stu = Console.ReadLine().Split();

    for (int j = 1; j < stu.Length; j++)
    {
        sum += int.Parse(stu[j]);
    }
    int arv = sum / int.Parse(stu[0]);

    for (int j = 1; j < stu.Length; j++)
    {
        if (arv < int.Parse(stu[j]))
        {
            count++;
        }
    }
    Console.WriteLine($"{(float)count / float.Parse(stu[0]) * 100:0.000}%");
}