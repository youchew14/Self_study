int hs = int.Parse(Console.ReadLine());
int sp = int.Parse(Console.ReadLine());
int ms = int.Parse(Console.ReadLine());
int mh = int.Parse(Console.ReadLine());

int all = hs + sp + ms + mh;

Console.WriteLine("{0}\n{1}", all/60, all%60);