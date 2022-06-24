int test_case = int.Parse(Console.ReadLine());

for (int i = 0; i < test_case; i++)
{
    string[] user = Console.ReadLine().Split();
    int a = int.Parse(user[0]);
    int b = int.Parse(user[1]);
    
    Console.WriteLine(a + b);
}