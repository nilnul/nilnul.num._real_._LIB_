using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num._real.approach;
using nilnul.num.quotient.range.be_;

namespace nilnul.num._real.approach_.nonzero.op_._inverse
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///		consider:
	///			1) 1/(1-x)=1+x+x^2+...
	///			2) 1/(1-x)=(1+x)(1+x^2)(1+x^4).
	/// </remarks>
	public class Ret
				:
			_call.ArgA<approach.be_.Nonzero.En>
			,

			approach_.NotZeroI
			,
			//real.be.NotZero.Asserted
			//,
			ApproachI1
	{





		public Ret(approach.be_.Nonzero.En a)

			: base(a)

		{


			//op_._inverse.ShiftFroZero.Proc(a);


		}


		public Ret(ApproachI1 a)

		: this(new approach.be_.Nonzero.En(a))

		{




		}


		public Ret(BigInteger a)
				: this(new approach.be_.Nonzero.En(a))
		{
		}

		public Nonempty.En bound
		{
			get
			{


				return new Nonempty.En(
					nilnul.num.quotient.border.duo.be_.nonempty.noZero.Invertible.En.Inverse(arg.val.bound).val

					);

				// new NotImplementedException();

			}
		}

		public NoApproachZero.En range
		{
			get
			{
				return arg.bound_noApproachZero;


				//throw new NotImplementedException();
			}
		}

		public void clamp(Positive1.En diameter)
		{

			while (bound.notSpanLessThan(diameter))
			{
				arg.val.Clamp1K(
				);

			}

			//return;

			//	throw new NotImplementedException();
		}
	}
}
