int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

DateTime day = new DateTime(2007, n[0], n[1], 00, 00, 00);

Console.WriteLine(day.DayOfWeek.ToString().ToUpper()[..3]);