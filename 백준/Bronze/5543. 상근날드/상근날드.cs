int[] burger = new int[3];
burger[0] = int.Parse(Console.ReadLine());
burger[1] = int.Parse(Console.ReadLine());
burger[2] = int.Parse(Console.ReadLine());

int[] juice = new int[2];
juice[0] = int.Parse(Console.ReadLine());
juice[1] = int.Parse(Console.ReadLine());

int set_cost = 0;

set_cost += Math.Min(juice[0], juice[1]);
set_cost += Math.Min(burger[0], Math.Min(burger[1], burger[2]));

Console.WriteLine(set_cost - 50);