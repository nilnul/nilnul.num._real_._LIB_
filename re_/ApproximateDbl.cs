using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;
using nilnul.num.quotient_;

namespace nilnul.num.real.re_
{
	/// <summary>
	/// symmectric
	/// reflexive
	/// not transitive
	/// </summary>
	public class ApproximateDbl 
		:
		nilnul.obj.Box<double>
		,
		nilnul.num.real.ReDblI
	{

		private nilnul.num.real.be_.AbsLeDbl _absLe;
		public ApproximateDbl(nilnul.num.real_.NonnegOfDouble val) : base(val)
		{
			_absLe = new be_.AbsLeDbl(val);
		}

		

		public ApproximateDbl(int i) : this(new real_.NonnegOfDouble(i))
		{
		}

		public ApproximateDbl(double x) : this(
			new real_.NonnegOfDouble(x)
		)
		{

		}

		public ApproximateDbl():this(double.Epsilon)
		{

		}



		public bool re(double a, double b)
		{
			return _absLe.be(a - b);
		}


		static public ApproximateDbl CreateByAbs(double x) {
			return new ApproximateDbl(
				nilnul.num.real_.nonneg.coerce_._AbsX.Doub(x)
			);
		}


		static public ApproximateDbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ApproximateDbl>.Instance;
			}
		}



	}
}
