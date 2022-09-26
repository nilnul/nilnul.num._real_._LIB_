using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real_
{
	static public class _FlooredX
	{

		static public (BigInteger,R ) TailAsReal(nilnul.num.RealI result) {

			
			var floor = nilnul.num.real._FloorX.Floor(
				result
			);


			return  (floor,    
				
				nilnul.num.real.op_.binary_.Minus.Singleton.op (result,floor) 
				
			);
		}



	}
}
