using System;
using System.Collections.Generic;

public class ProgramClass
{
	public static void Main()
	{
		var x = new List<int>();
		x.Add(1);
		x.Add(10);
		x.Add(3);
		x.Add(9);
		int i = 0;
		foreach(int j in x)
        {
            Console.Write("At Position {0}: ", i);
            Console.WriteLine(j);
            i++;
        }
  
  

	}
}

