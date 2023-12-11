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
	{
		int[] arrInt = new int[] { 1, 2, 3, 5, 4, 1, 3, 4, 5, 4, 5, 9, 7, 0, 11, 13, 10, 23 };

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
