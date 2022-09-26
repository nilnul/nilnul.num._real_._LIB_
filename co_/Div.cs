
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RI = nilnul.num.RealI;
using Rq = nilnul.num.real_.Quotient;
using nilnul.num._quotient.fraction.op;

using nilnul._num.bigint.be;
using Q0 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;

using N = nilnul.Num;//_num.bigint.be.Natural.Asserted;

using System.Numerics;

namespace nilnul.num.real.co_
{
	public class Divisible
		:Tuple<RI, nilnul.num.real_.NonnilI>
	{

		 public  Divisible(RI a, nilnul.num.real_.NonnilI b):base(a,b) {
			
		}

		public Divisible(RI a, RI b): this(
				a
				,
				new nilnul.num.real_.Nonnil(b)
			) {
			;
		}
		public   Divisible(nilnul.num.real_.Quotient a, RI b):this(
			(RI)(a)
			,
			b
		)
		{
			
		}


	

		public   Divisible(Q0 a, RI b):this(
			new nilnul.num.real_.Quotient(a)
			,
			b
		)
		{
			
		}

		public Divisible(RI a, NumI1 b):this(
			a
			,
			new nilnul.num.real_.Quotient(b)
		)
		{
			
		}

		public Divisible(RI a, BigInteger b):this(
			a
			,
			new nilnul.num.real_.Quotient(b)
		)
		{
			
		}

		public  Divisible(RI a, NumI b)
			:this(a, b.toBigint() )
		{


		}
	}
}