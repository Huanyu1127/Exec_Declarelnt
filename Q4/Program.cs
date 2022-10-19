using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.Write("請輸入第一個整數：");
			string input1 = Console.ReadLine();
			Console.Write("請輸入第二個整數：");
			string input2 = Console.ReadLine();
			int number1 = Convert.ToInt32(input1);
			int number2 = Convert.ToInt32(input2);
			if (number1 < number2)
			{
				int temp = number1;
				number1 = number2;
				number2 = temp;
			}
			else if (number1 == number2)
			{
				Console.WriteLine("輸入的數是相同的，第一個是" + number1 + "第二個也是" + number2);
				return;
			}
			Console.WriteLine("輸入的數由大到小排列，大的是" + number1 + "小的是" + number2);
			
		}
    }
}
