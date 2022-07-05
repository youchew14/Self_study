string[] a = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(a, int.Parse);
int[] A = new int[num.Length];
int ar = 0;

string[] b = Console.ReadLine().Split(' ');
int[] num2 = Array.ConvertAll(b, int.Parse);
int[] B = new int[num2.Length];
int br = 0;

int[] score = { 6, 3, 2, 1, 2 };

for (int i = 0; i < num.Length; i++)
{
    A[i] = num[i] * score[i];
    B[i] = num2[i] * score[i];
    ar += A[i];
    br += B[i];
}
Console.WriteLine("{0} {1}", ar, br);