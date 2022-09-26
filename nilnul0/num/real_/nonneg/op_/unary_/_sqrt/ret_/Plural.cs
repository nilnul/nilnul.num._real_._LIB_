using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.rational.be;
using nilnul.num.rational.bound.pair.be;
using N = nilnul.num.natural.Natural_bigInteger;
using N1 = nilnul._num.bigint.op.Abs.Ed;
using N2 = nilnul._num.bigint.be_.Plural.En;

using Q = nilnul.num.rational.Rational_InheritFraction2;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using System.Numerics;
using nilnul.num.real;
using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num._real._approach.members;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num._real.approach.op_._sqrt.ret_.ofN_
{


	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// Naming: N is too short. 
	/// </remarks>
	public class Plural
		:
		nilnul._call.ArgA<N2>
		,
		nilnul.num._real.ApproachI1
	{

		public Plural(N2 arg):base(arg)
		{
		}
		
		public Plural(int arg) : this(new N2(arg))
		{
		}

		public Plural(BigInteger arg)
			: this(new N2(arg))
		{
		}

		private quotient.border.duo.be_.Nonempty.En _bound;
		public		quotient.border.duo.be_.Nonempty.En bound
		{
			get
			{
				return _bound;
			}
		}

		

		public void clamp(int i)
		{
			clamp(new quotient.be_.Positive1.En(i));
		}


		public void clamp(quotient.be_.Positive1.En diameter)
		{

			if (bound.notSpanLessThan(diameter))
			{
				var middle = bound.midPoint;

				var middleSquare =   middle * middle;


				var compareResult = nilnul.num.quotient.Le.Singleton.Compare(
					 nilnul.num.quotient.op.SquareX.Square( middle)
					
					, 

					 arg
				);

				if (compareResult == 0)
				{
					_bound = nilnul.num.quotient.border.duo.be_.Nonempty.En.CreateSingleton(middle);

				
				}
				else if (compareResult < 0)
				{
					_bound = nilnul.num.quotient.border.duo.be_.Nonempty.En.CreateOpen(middle,bound.upper.mark);
					
					


				}
				else
				{
					_bound = nilnul.num.quotient.border.duo.be_.Nonempty.En.CreateOpen(bound.lower.mark,middle);
					

				}

			}
		
		}

		
	}

}
