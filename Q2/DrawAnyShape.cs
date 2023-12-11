using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class DrawAnyShape
	{
		public void drawDiamond(int height)
		{
            if (height <= 0) return;
			Console.WriteLine($"{new String(' ', height)}*");
            for (int i = 1; i <= height; i++)
            {
                Console.WriteLine($"{new String(' ', height - i)}*{new String(' ', 1 + 2 * (i-1))}*");
            }
            for (int j = height-1; j >= 1; j--)
            {
                Console.WriteLine($"{new String(' ', height - j)}*{new String(' ', 1 + 2 * (j - 1))}*");
            }
            Console.WriteLine($"{new String(' ', height)}*");
            
        }
	}
}
