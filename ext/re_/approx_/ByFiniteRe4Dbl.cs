using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;
using nilnul.num.quotient_;

namespace nilnul.num.real.ext.re_.approx_
{
	/// <summary>
	/// symmectric
	/// reflexive
	/// not transitive
	/// </summary>
	public class ByFiniteRe4Dbl 
		:
		nilnul.obj.Box_ofIn<nilnul.num.real.re_.ApproximateDbl>
		,
		nilnul.num.real.ext.Re4dblI
	{
		public ByFiniteRe4Dbl(in real.re_.ApproximateDbl val) : base(val)
		{
		}

		public ByFiniteRe4Dbl(real.re_.ApproximateDbl x) : base(x)
		{
		}

		public ByFiniteRe4Dbl(nilnul.num.real_.NonnegOfDouble val) : this(new real.re_.ApproximateDbl( val) )
		{
		}

		

		public ByFiniteRe4Dbl(int i) : this(new real_.NonnegOfDouble(i))
		{
		}

		public ByFiniteRe4Dbl(double x) : this(
			new real_.NonnegOfDouble(x)
		)
		{

		}

		public ByFiniteRe4Dbl():this(double.Epsilon)
		{

		}




		static public ByFiniteRe4Dbl CreateByAbs(double x) {
			return new ByFiniteRe4Dbl(
				nilnul.num.real_.nonneg.coerce_._AbsX.Doub(x)
			);
		}
		public bool _re_01ext(double a, double b)
		{
			if (double.IsNegativeInfinity(a) )
			{
				if (double.IsNegativeInfinity(b))
				{
					return true;
				}
				return false;
			}
			if (double.IsPositiveInfinity(a) )
			{
				return _re_01ext(-a,-b);
			}
			if (double.IsInfinity(b) )
			{
				return _re_01ext(b, a);
			}
			///finite;
			return boxed.re(a, b);
		}

		public bool re(Ext4dblI a, Ext4dblI b)
		{
			return _re_01ext(a.errable, b.errable);
		}


		static public ByFiniteRe4Dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ByFiniteRe4Dbl>.Instance;
			}
		}



	}
}
