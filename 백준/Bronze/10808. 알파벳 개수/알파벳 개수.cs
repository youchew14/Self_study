string day = Console.ReadLine();
string[] en = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z".Split(",");
int[] count = new int[26];


for (int i = 0; i < day.Length; i++)
{
    for (int j = 0; j < en.Length; j++)
    {
        if (day[i].ToString() == en[j].ToString())
        {
            count[j]++;
        }
    }
}
Console.WriteLine(string.Join(" ", count));