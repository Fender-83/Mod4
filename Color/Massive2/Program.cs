using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive2
{
    internal class Program
    {
        static void Main(string[] args)
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int sum = 0;

		for (int i = 0; i<arr.Length; i++)
		{
			sum += arr[i];
		}

    Console.WriteLine(sum);
  }
}
