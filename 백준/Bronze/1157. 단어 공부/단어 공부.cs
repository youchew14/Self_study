string user = Console.ReadLine().ToUpper();

string[] en = "a,b,c,d,e,f,g,h,i,j,k,l,n,m,o,p,q,r,s,t,u,v,w,x,y,z".ToUpper().Split(",");
int[] count = new int[26];

int max = 0;
int index = 0;
bool print = false;

for (int i = 0; i < user.Length; i++)
{
    for (int j = 0; j < en.Length; j++)
    {
        if (user[i].ToString() == en[j].ToString())
        {
            count[j]++;
        }
    }
}
for (int i = 0; i < count.Length; i++)
{
    if (max == count[i] && user.Length != 0)
    {
        print = true;
    }
    else if (max < count[i])
    {
        max = count[i];
        index = i;

        print = false;
    }

}
if (print)
{
    Console.WriteLine("?");
}
else
{
    Console.WriteLine(en[index]);
}