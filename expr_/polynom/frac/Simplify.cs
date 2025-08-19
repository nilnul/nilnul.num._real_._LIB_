using nilnul.num.real.expr_.algebraic_.pows.prod.scaleds;
using nilnul.obj.seq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.frac
//_.pows.prod.scaleds.sum
{
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete("For multivariate, this is hard, see unit tests. let's define Eq first.", true)]
	public class Simplify
	{
		private Sum_powIndexPositive _numerator;

		public Sum_powIndexPositive numerator
		{
			get { return _numerator; }
			set { _numerator = value; }
		}

		private Sum_powIndexPositive _denominator;

		public Sum_powIndexPositive denominator
		{
			get { return _denominator; }
			set { _denominator = value; }
		}

		public Rational(
			Sum_powIndexPositive numerator
						,
			Sum_powIndexPositive denominator
		)
		{
			this._numerator = numerator;
			this._denominator = denominator;
		}

		public Rational toSimplify() {
			var n = _numerator.toSimplify();
			var d = _denominator.toSimplify();

			var nMaxTermS = nilnul.rel_.net_.poset.nodes_._MinmimalX.Minimal(
				n.scaleds
				,
				//(s, s1) =>
				algebraic_.pows.prod.scaled.re_.Multiplic.Singleton//.re
				//(s.product, s1.product)
			);
			var dMaxTermS = nilnul.rel_.net_.poset.nodes_._MinmimalX.Minimal(
				d.scaleds
				,
				 algebraic_.pows.prod.scaled.re_.Multiplic.Singleton
			);
			if (dMaxTermS.None())
			{
				throw new DivideByZeroException(
					$"Denominator:{_denominator}, simplified as:{d} is nil."
				);
			}
			nMaxTermS.Select(
				nMaxterm => 
			);



		}


	}
}
