using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class ArrIntManager
	{//                            4        2  2  4        3
//								   1  1  1  1  2  1  2  3  4 |5| 1	1
		int[] arrInt = new int[] { 1, 2, 3, 5, 4, 6, 5, 4, 3, 2, 4, 5 }; // MAX: 5+1 = 6
//								   1  2  3  4  1  2  1  1  1 |1| 3  2
									
		public int longestStableSequence()
		{
			int len = arrInt.Length;
			if (len <= 2) return len;
			List<int> inc = new List<int>(new int[len]); 
			List<int> dec = new List<int>(new int[len]);
			int saved = 2;

			for (int i = 0; i < len; i++)
			{
				inc[i] = 1;
				dec[i] = 1;
			}
													//incrementing seq. length list
			for (int i = 1; i < len; i++)
				if (arrInt[i] >= arrInt[i - 1])
					inc[i] = inc[i - 1] + 1;                         
													//decreasing seq. length list
			for (int i = len - 2; i >= 0; i--)
				if (arrInt[i] >= arrInt[i + 1])
					dec[i] = dec[i + 1] + 1;


			for (int i = 0; i < len; i++)
				saved = Math.Max(saved, inc[i] + dec[i] - 1);

			return saved;
		}
		public int sumOfArray()
		{
			int sum = 0;
			foreach (int i in arrInt)
			{
				sum += i;
			}
			return sum;
		}
		public bool isPrime(int n)
		{
			if (n < 2) return false;
			for (int i = 2; i <= (int)Math.Sqrt(n); i++)
			{
				if (n % i == 0)
				{
					return false;
				}
			}
			return true;
		}
		public int sumOfPrimes()
		{
			int sum = 0;
			foreach (int i in arrInt)
			{
				if (isPrime(i))
				{
					sum += i;
				}
			}
			return sum;
		}
		public void getTrio()
		{
			int count = 0;
			if (arrInt.Length < 3)
			{
				Console.WriteLine("No set of three numbers.");
			}
			else
			{
				for (int i = 0; i < arrInt.Length - 2; i++)
				{
					if (arrInt[i] + arrInt[i + 1] == arrInt[i + 2])
					{
						count++;
						Console.WriteLine($"({arrInt[i]},{arrInt[i + 1]},{arrInt[i + 2]})");
					}
				}
			}
		}
		public void longestSubArray(int sum)
		{
			int startindex = 0;
			int s;
			int maxcount = 0;
			int savedindex = 0;
			while (startindex < arrInt.Length)
			{
				s = arrInt[startindex];
				int i = startindex + 1;
				int count = 0;
				while (s < sum && i < arrInt.Length)
				{
					s += arrInt[i];
					i++;
					count++;
				}
				if (count > maxcount && s==sum)
				{
					maxcount = count;
					savedindex = startindex;
				}
				
				startindex++;
			}
			if (maxcount == 0)
			{
				Console.WriteLine("No subarray found.");
			}
			else
			{
				for (int i = 0; i <= maxcount; i++)
				{
					Console.Write(arrInt[savedindex+i] + " ");
                    
                }
			}
		}
		public void longestSubArrays(int sum)
		{
			int startindex = 0;
			int s;
			int maxcount = 0;
			int savedindex = 0;
			while (startindex < arrInt.Length)
			{
				s = arrInt[startindex];
				int i = startindex + 1;
				int count = 0;
				while (s <= sum && i < arrInt.Length)
				{
					s += arrInt[i];
					i++;
					count++;
				}
				if (count > maxcount)
				{
					maxcount = count;
				}
				savedindex = startindex;
				startindex++;
			}
			if (maxcount == 0)
			{
				Console.WriteLine("No subarray found.");
			}
			else
			{
				for (int i = savedindex; i < maxcount; i++)
				{
					Console.Write(arrInt[i] + " ");
				}
			}
		}
	}
}
