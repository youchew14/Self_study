int t = int.Parse(Console.ReadLine());

while(t-- > 0)
{
    int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    Queue<(int, int)> queue = new Queue<(int, int)>();

    int[] dx = { 1, 0, -1, 0 };
    int[] dy = { 0, 1, 0, -1 };

    int count = 0;

    int[,] board = new int[51, 51];
    int[,] visited = new int[51, 51];

    for (int i = 0; i < n[2]; i++)
    {
        int[] p = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        board[p[0], p[1]] = 1;
    }
    for (int i = 0; i < n[0]; i++)
    {
        for (int j = 0; j < n[1]; j++)
        {
            if (board[i, j] == 0 || visited[i, j] == 1)
            {
                continue;
            }
            queue.Enqueue((i, j));
            count++;

            while(queue.Count != 0)
            {
                var cur = queue.Dequeue();
                int x = cur.Item1;
                int y = cur.Item2;

                for (int d = 0; d < 4; d++)
                {
                    int nx = cur.Item1 + dx[d];
                    int ny = cur.Item2 + dy[d];
                    if (nx < 0 || ny < 0 || nx >= n[0] || ny >= n[1]) continue;
                    if (visited[nx, ny] == 1 || board[nx, ny] != 1) continue;

                    visited[nx, ny] = 1;
                    queue.Enqueue((nx, ny));
                }
            }
        }
    }
    Console.WriteLine(count);
}