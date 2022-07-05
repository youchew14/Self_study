int[] num = new int[5];
int day = 1; // 걸린 일수

for (int i = 0; i < 5; i++)
{
    // 방학일수, 수학숙제, 국어숙제, 국어하루량, 수학하루량
    num[i] = int.Parse(Console.ReadLine());
}
while(true)
{
    //Console.WriteLine("day : {0}", day);
    num[1] -= num[3];
    num[2] -= num[4];
    //Console.WriteLine("{0} {1}", num[1], num[2]);
    if (num[1] <= 0 && num[2] <= 0)
    {
        break;
    }
    day++;
}
//Console.WriteLine("day : {0}", day);
Console.WriteLine(num[0] - day);