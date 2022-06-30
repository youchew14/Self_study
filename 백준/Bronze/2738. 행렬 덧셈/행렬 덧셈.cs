string[] user = Console.ReadLine().Split();
int n = int.Parse(user[0]); // row
int m = int.Parse(user[1]); // column

string[] matrixA = new string[n];
string[] matrixB = new string[n];

for (int i = 0; i < n; i++)
{
    matrixA[i] = Console.ReadLine();
}
for (int i = 0; i < n; i++)
{ 
    matrixB[i] = Console.ReadLine();
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < matrixA[i].Split().Length; j++)
    {
        Console.Write((int.Parse(matrixA[i].Split()[j].ToString()) + int.Parse(matrixB[i].Split()[j].ToString())) + " ");
    }
    Console.WriteLine();
}