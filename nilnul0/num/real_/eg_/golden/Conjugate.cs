using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real;

namespace nilnul.num.real_.golden
{
	/// <summary>
	/// the root, conjugate to goldenRatio, of formula x^2-x-1=0;
	/// 0.618...
	/// The golden ratio conjugate, also called the silver ratio, is the quantity  1/phi where phi is the golden ratio.  2 / (1+sqrt(5) ) = (sqrt(5) - 1 )/2
	/// </summary>
	static public class _ConjugateX

	{
		[Obsolete("perf in favor of "+ nameof(Conjugate))]
		static public nilnul.num.real_.NonnilI Computed =
		nilnul.num.real_.nonnil.op_.unary_._InverseX.Op(
					 nilnul.num.real_.GoldenRatio.Singleton
				)

		;


		

	}


	public class Conjugate
		:

		real.op_.unary_._shift._Ret_shiftNotZero
		,
					RealI

	{



		public Conjugate() : base(
			-num.Quotient1.CreateHalf()
			,
			real.op_.unary_._ScaleX.Halve(
				real_.nonneg.op_.unary_._SqrtX.RetRealI(5))
			)
		{
		}


		static public Conjugate Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Conjugate>.Instance;
			}
		}

	}

}
