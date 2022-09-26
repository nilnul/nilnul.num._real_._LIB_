using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.cauchy_._wallis.product_._uniform
{
	public class Term
	{
		static public nilnul.num.Quotient1 Op(nilnul.num_.Positive1 x) {
			var four_n_sq = 4 * nilnul.num.op_.unary_.Square.Num(x);
			return new nilnul.num.Quotient1(
				four_n_sq
				,
				four_n_sq - 1
			);
		}

		static public nilnul.num.quotient.slider_.Func func =  slider_.Func.CreatePositive(
			x=> Op(new num_.Positive1(x))
			
		);
	}


}
