// 지도의 크기를 입력한다.
int n = int.Parse(Console.ReadLine());

int[,] arr = new int[25, 25]; // 지도
int[,] visi = new int[25, 25]; // 방문 여부
List<int> house = new List<int>(); // 집 수
Queue<(int, int)> queue = new Queue<(int, int)>(); // 큐 리스트 생성

//상하좌우 
int[] dx = { 1, 0, -1, 0 };
int[] dy = { 0, 1, 0, -1 };
int c = 0; // 단지 수

// 집 입력 및 저장
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();

    for(int j = 0; j < s.Length; j++)
    {
        arr[i, j] = int.Parse(s[j].ToString());
    }
}
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (arr[i, j] == 0 || visi[i, j] == 1) continue;
        queue.Enqueue((i, j));
        int h = 0;

        while(queue.Count != 0)
        {
            var cur = queue.Dequeue();
            int x = cur.Item1;
            int y = cur.Item2;

            for (int d = 0; d < 4; d++)
            {
                // 상하좌우 움직이기
                int nx = cur.Item1 + dx[d];
                int ny = cur.Item2 + dy[d];
                if (nx < 0 || ny < 0 || nx >= arr.GetLength(0) || ny >= arr.GetLength(1)) continue;
                if (visi[nx, ny] == 1 || arr[nx, ny] != 1) continue;
                visi[nx, ny] = 1;
                h++; // 움직인 수 == 집 수
                queue.Enqueue((nx, ny));
            }
        }
        house.Add(h);
        c++;
    }
}
Console.WriteLine(c); // 단지수 출력
house.Sort(); // 오름차순 정렬
for (int i = 0; i < house.Count; i++)
{
    if (house[i] == 0)
    {
        Console.WriteLine(1);
    }
    else
    {
        Console.WriteLine(house[i]); // 집수 출력
    }
}