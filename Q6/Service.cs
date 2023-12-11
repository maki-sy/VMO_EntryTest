using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Service
	{
		public double getMed(int[] arr1, int[] arr2)  // assign value until (m+n)/2 - time, return the value of the last index.
		{
			int med = 0;
			int m = arr1.Length;
			int n = arr2.Length;

			int medindex = (m + n) / 2;	      
			if((m+n)%2 == 0)
			{
				medindex--;
			}
			int i = 0, j = 0, k = 0;     

			for (k = 0; k <= medindex; k++)    
			{
				if (i != m && j != n)
				{
					if (arr1[i] <= arr2[j])
					{
						med = arr1[i];
						//Console.WriteLine(med);

						i++;
					}
					else
					{
						med = arr2[j];
                        //Console.WriteLine(med);
                        j++;
					}
				}
				else
				{
					if (j < n)
					{
						med = arr2[j];
						//Console.WriteLine(med);

						j++;
					}
					else
					{
						med = arr1[i];
						//Console.WriteLine(med);
						i++;
					}
				}
			}

			return med;
		}
	}
}
