int n = int.Parse(Console.ReadLine());
string result = "";
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    int number = int.Parse(input[0]);
    int L1 = int.Parse(input[1]);
    int L2 = int.Parse(input[2]);
    int L3 = int.Parse(input[3]);
    int totalScore = L1 + L2 + L3;
    string state;
    if (totalScore >= 55)
    {
        if ((L1 >= 35 * 0.3) && (L2 >= 25 * 0.3) && (L3 >= 40 * 0.3))
        {
            state = "PASS";
        }
        else
        {
            state = "FAIL";
        }
    }
    else
    {
        state = "FAIL";
    }
    result += number + " " + totalScore + " " + state + "\n";
}

Console.WriteLine(result);