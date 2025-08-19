using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace nilnul.number.uinteger
{
	static public partial class SqrtFloorX
	{

	

		static public BigInteger SqrtFloor(this BigInteger i) {
			//truncate half.

			if (i<0)
			{
						throw new Exception();
		 
			}



			var x = i.Log2Floor();

			var y = x / 2; //floor of the number.

			while (x * x < i) {
				x++;

			}
			if (x*x==i)
			{
				return x;
				
			}
			return x-1;

			
			
 

		
		}
				
	}
}
