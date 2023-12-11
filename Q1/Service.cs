using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Q1
{
	internal class Service
	{
		public double baseValidate()                    ////validate and return base as a double, loop until validated
		{
			double x;
			Console.Write("Base = ");
			while(!double.TryParse(Console.ReadLine(), out x))
			{
				Console.WriteLine("Please enter a valid number.");
				Console.Write("Base = ");
			}
			return x;
		}
		public int expValidate()                      //validate and return exponent as an integer, loop until validated
		{
			int n;
			Console.Write("Exp = ");
			while (!int.TryParse(Console.ReadLine(), out n)||n<=0)
			{
				Console.WriteLine("Please enter a valid number that's larger than 0.");
				Console.Write("Exponent = ");
			}
			return n;
		}
		public double sumOfSquares(double x, int n)   // handled case: base number is a decimal
		{											  // unhandled case: big sum that requires BigInteger
			//if(n == 0) return x;
			//if (x == 0) return n;
			double sum=x;
			for (int i = 1; i <= n; i++)
			{
				sum += Math.Pow(x, i);
			}
			return sum;
		}
	}
}
