using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiwanStock.Utility;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var obj = new Class1();

			Console.WriteLine(obj.isTradingTime(DateTime.Now));

		}
	}
}
