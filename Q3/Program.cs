using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int remainder1 = 202 % 2;
			Console.WriteLine("第三題202/2的餘數是" + remainder1 + "所以他是偶數");

			if (remainder1 == 0)
			{
				Console.WriteLine("if寫法　202是偶數");
			}
			else
			{
				Console.WriteLine("if寫法　202是奇數");
			}
			int remainder2 = 9 % 2;
			Console.WriteLine("第四題9/2的餘數是" + remainder2 + "所以他是奇數");

			if (remainder2 == 0)
			{
				Console.WriteLine("if寫法　9是偶數");
			}
			else
			{
				Console.WriteLine("if寫法　9是奇數");
			}
		}
    }
}
