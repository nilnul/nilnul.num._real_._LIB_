using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.unary_
{
	static public class _PermutateX
	{
		static public nilnul.num.Real _Op_assumeIntNonneg(int num, nilnul.num.RealI real ) {
			var arithSeq = new nilnul.num.real.stream_.slider_.arithmetic_.Decrement(real);

			return nilnul.num.real.str._ProdX.Prod_byLoop (
				nilnul.obj.stream._FetchX._FetchDefered(
					arithSeq, num
				
				)
			);
		}
	}
}
