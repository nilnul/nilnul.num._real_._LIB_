using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;
using nilnul.num.quotient_;
using nilnul.num.real.be_;
using R = nilnul.num.RealI_onQuotient;

namespace nilnul.num.real.re_
{
	/// <summary>
	/// symmectric
	/// reflexive
	/// not transitive
	/// </summary>
	public class Approximate_onQuotient 
		:
		nilnul.obj.Box_ofIn<real.be_.Insignific>
		,
		nilnul.num.real.ReI_onQuotient
		,INear
	{

		public Approximate_onQuotient(nilnul.num.quotient_.denomNonnil_.Nonneg val) : base( new Insignific(val) )
		{
		}

	

		public Approximate_onQuotient(nilnul.num.quotient_.DenomNonnil quotient) : this(new nilnul.num.quotient_.denomNonnil_.Nonneg(quotient))
		{
		}

		public Approximate_onQuotient(int i) : this(new num.quotient_.DenomNonnil(i))
		{
		}

		public Approximate_onQuotient(double x) : this(
			nilnul.num.quotient_.radix.ext.errable_.ieee_.bin.to_._ToRationalX.ToSignificed(x).toDenomNonnil()
		)
		{

		}

		public Approximate_onQuotient(in Insignific val) : base(val)
		{
		}

		public Approximate_onQuotient(Insignific x) : base(x)
		{
		}

		public bool re(R0 a, R0 b)
		{
			return boxed.be(a.ToImpl() - b);
		}

		public bool re(R0 a, nilnul.num.real_.Quotient_denomNonnil b)
		{
			return re(a, (R0)(b));
		}
		

		public bool re(R0 a, double b)
		{
			return re(a, nilnul.num.quotient_.radix.ext.errable_.ieee_.bin.to_._ToRationalX.ToSignificed(b).toDenomNonnil());
		}
		public bool re(R0 a, int b)
		{
			return re(a,  new nilnul.num.real_.Quotient_denomNonnil(b));
		}

		public bool re( double b, R0 a)
		{
			return re(a, b);
		}

	
	}
}
