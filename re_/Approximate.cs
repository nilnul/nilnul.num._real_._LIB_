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
	public class Approximate 
		:
		nilnul.obj.Box<nilnul.num.quotient_.NonnegI>
		,
		nilnul.num.real.ReI
	{

		private nilnul.num.real.be_.AbsLe _absLe;
		public Approximate(NonnegI val) : base(val)
		{
			_absLe = new be_.AbsLe(val);
		}

		public Approximate(num.quotient_.Nonneg val) : this((NonnegI)val)
		{
		}

		public Approximate(nilnul.num.Quotient1 quotient) : this(new nilnul.num.quotient_.Nonneg(quotient))
		{
		}

		public Approximate(int i) : this(new num.Quotient1(i))
		{
		}

		public Approximate(double x) : this(
			nilnul.num.quotient_._DblX.Constuct(x)
		)
		{

		}



		public bool re(RealI a, RealI b)
		{
			return _absLe.be(a.ToReal() - b);
		}

		public bool re(RealI a, nilnul.num.real_.Quotient b)
		{
			return re(a, (RealI)(b));
		}
		public bool re(RealI a, nilnul.num.Quotient1 b)
		{
			return re(a, new nilnul.num.real_.Quotient(b));
		}

		public bool re(RealI a, double b)
		{
			return re(a, nilnul.num.quotient_._DblX.Constuct(b));
		}
		public bool re(RealI a, int b)
		{
			return re(a,  new nilnul.num.real_.Quotient(b));
		}

		public bool re( double b, RealI a)
		{
			return re(a, b);
		}



	}
}
