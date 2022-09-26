using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace nilnul.number.uinteger
{
	public static class Log2FloorX
	{
		public static int Log2Floor(this BigInteger i) {
			int x=(int) (Math.Floor(BigInteger.Log(i, 2)));


			//search around x
			//decide the direction
			var y = BigInteger.Pow(2, x);
			while (y<i)
			{
				x++;
				y = BigInteger.Pow(2, x);

				if (y > i) { return x-1; }
	
				
			}
		

			while (y > i) {
				x--;
				y = BigInteger.Pow(2, x);
				if (y < i) { return x; }
			
			}
			return x;
		

		
		}
	}
}
