using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider_.arithmetic
{
	static public class _CumulusX
	{
		static public nilnul.num.RealI SumUp2numero(
			nilnul.num.Real starter
			,
			nilnul.num.Real rate
			,
			nilnul.Num1 numero
		) {
			return starter * (numero+1) + arithmetic_.std._CumulusX.SumUp2numero(rate, numero);
			
		}


		static public nilnul.num.RealI SumBeforeNumero(
			nilnul.num.Real starter
			,
			nilnul.num.Real rate
			,
			nilnul.Num1 numero
		) {
			if (numero==0)
			{
				return new nilnul.num.real_.Quotient();
			}
			return SumUp2numero(starter, rate,  numero-1);
			
		}




	}
}
