string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

int chicken = int.Parse(Console.ReadLine()) * 2;

int sum = num[0] + num[1];

if (sum >= chicken)
{
    Console.WriteLine(sum - chicken);
}
else if (sum < chicken)
{
    Console.WriteLine(sum);
}