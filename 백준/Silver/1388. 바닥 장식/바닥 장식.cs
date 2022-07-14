int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

string[,] tree = new string[51, 51];
int c = 0;

for (int i = 0; i < n[0]; i++)
{
    string s = Console.ReadLine(); // 장판 무늬 입력

    for (int j = 0; j < n[1]; j++)
    {
        tree[i, j] = s[j].ToString(); // 위치에 추가
    }
}
// 한번씩 방문하기
for (int i = 0; i < n[0]; i++)
{
    for (int j = 0; j < n[1]; j++)
    {
        int x = j + 1;
        int y = i + 1;
        if (y > n[0] || x > n[1]) continue;
        // 무늬가 같지 않을 경우만
        if (tree[i, j] == "|" && tree[y, j] != "|") c++;
        else if (tree[i, j] == "-" && tree[i, x] != "-") c++;
    }
}
Console.WriteLine(c);