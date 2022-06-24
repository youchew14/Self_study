using System;
using System.Text;

namespace BackJoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int test_case = int.Parse(Console.ReadLine());
            StringBuilder num = new StringBuilder();

            for (int i = 0; i < test_case; i++)
            {
                string[] user = Console.ReadLine().Split();
                int a = int.Parse(user[0]);
                int b = int.Parse(user[1]);
                num.Append(a + b + "\n"); // 문자열로 저장된다.
            }
            Console.WriteLine(num.ToString());
        }
    }
}
