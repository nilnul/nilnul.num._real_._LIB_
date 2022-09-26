using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.co_.divisible.div_
{
	static public class _RetFlooredX
	{

		static public (BigInteger,R ) Div(nilnul.num.RealI dividend, nilnul.num.real_.NonnilI divisor) {

			//var result = co_.divisible.bind_._DivX.Bind(
			//		dividend
			//		,
			//		divisor
			//	);

			return nilnul.num.real_._FlooredX.TailAsReal(
				co_.divisible._DivX.Bind(
					dividend
					,
					divisor
				)
			);
			//var floor = nilnul.num.real._FloorX.Floor(
			//	result
			//);


			//return  (floor,    
				
			//	nilnul.num.real.op_.binary_.Minus.Singleton.op (result,floor) 
				
			//);
		}

		static public (BigInteger, R) Div(co_.Divisible nonegPos) {
			return Div(
				nonegPos.Item1,nonegPos.Item2
			) ;
		}

		static public (BigInteger, R) Div(nilnul.num.RealI real, int divisor) {
			return Div(
				real, new nilnul.num.real_.Nonnil(divisor)
			) ;
		}


	}
}
