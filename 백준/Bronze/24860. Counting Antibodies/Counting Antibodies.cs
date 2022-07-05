string[] a = Console.ReadLine().Split(' ');
long[] num = Array.ConvertAll(a, long.Parse); //vk, jk

string[] b = Console.ReadLine().Split(' ');
long[] num2 = Array.ConvertAll(b, long.Parse); //vr, jr

string[] c = Console.ReadLine().Split(' ');
long[] num3 = Array.ConvertAll(c, long.Parse); //vh, dh, jh

Console.WriteLine("{0}", (num3[0]*num3[1]*num3[2]) * ((num[0]*num[1]) + (num2[0]*num2[1])));
