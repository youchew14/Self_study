string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

string[] paper = Console.ReadLine().Split(' ');
int[] paper_num = Array.ConvertAll(paper, int.Parse);

int re = num[0] * num[1];

for (int i = 0; i < paper.Length; i++)
{
    Console.Write(paper_num[i] - re + " ");
}