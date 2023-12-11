using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class MyString
	{

		public int getAsciiSum(string str)
		{
			int sum = 0;
			char[] arr = str.ToCharArray();
			foreach (char c in arr)
			{
                //Console.WriteLine(c.);
                sum += c;
			}
			return sum;
		}

		public int getAsciiUpperCaseSum(string str)
		{
			int sum = 0;
			char[] arr = str.ToCharArray();
			foreach (char c in arr)
			{
				if (Char.IsUpper(c))
				{
					sum += c;
				}
			}
			return sum;
		}
		public char[] ToDistinctCharArray(string str)
		{
			str = str.Replace(" ", "");
			char[] arr = str.ToCharArray();
			char[] uniquechars = arr.Distinct().ToArray();
			return uniquechars;
		}
		public Dictionary<char, int> countAppearance(string str, int n)
		{
			int sum = 0;
			char[] arr = str.ToCharArray();
			char[] uniquechars = ToDistinctCharArray(str);
			Dictionary<char, int> dict = new Dictionary<char, int>();

			foreach (char c in uniquechars)
			{
				int count = arr.Where(d => d==c).Count();
                //Console.WriteLine(count);
				if(count >= n)
				{
					dict[c] = count;
				}
            }
			return dict;
		}
		public int intValidate()                     
		{
			int n;
			Console.Write("Enter minimum appearance: ");
			while (!int.TryParse(Console.ReadLine(), out n )|| n<=0)
			{
				Console.WriteLine("Please enter a valid integer larger than 0.");
				Console.Write("Enter minimum appearance: ");
			}
			return n;
		}
		public void printResult(Dictionary<char, int> charcount, int n)
		{
			if (charcount.Count > 0)
			{
				for (int i = n; i <= charcount.Values.Max(); i++)
				{
					charcount.Where(x => x.Value == i).ToList();
					var list = charcount.Where(x => x.Value == i).ToList();
					if (list.Count > 0)
					{
						foreach (var item in list)
						{
							Console.Write($"\'{item.Key}\' ");
						}
						Console.Write(":" + i);
						Console.WriteLine();
					}
				}
			}
			else
			{
				Console.WriteLine("No minimal appearance of a char is found.");
			}
		}
		public string commonSubstring(string str1, string str2) 
		{
			return "";
		}
	}
}
