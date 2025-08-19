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
	/// </summary>
	public class ByBe 
		:
		nilnul.obj.Box1<nilnul.num.real.ext.be_.Small4dbl>
		,
		nilnul.num.real.ext.Re4dblI
	{

		public ByBe(nilnul.num.real.ext.be_.Small4dbl val) : base(  val )
		{
		}


		public ByBe(nilnul.num.real_.NonnegOfDoubleI val) : this( new nilnul.num.real.ext.be_.Small4dbl ( val ) )
		{
		}

		public ByBe(nilnul.num.real_.NonnegOfDouble val) : this( new nilnul.num.real.ext.be_.Small4dbl ( val ) )
		{
		}

			public ByBe(double x) : this(
			new real_.NonnegOfDouble(x)
		)
		{

		}
	

		public ByBe(int i) : this(new real_.NonnegOfDouble(i))
		{
		}

		private bool _re_01ext(double a,double b)
		{
			return boxed.be(
				ext.of_.binary_.Minus.Singleton._op_01ext(a, b)
			);
		}


		public bool re(Ext4dblI a, Ext4dblI b)
		{
			return _re_01ext(a.errable, b.errable);
		}
		public bool re(Ext4dbl a, Ext4dbl b)
		{
			return _re_01ext(a.errable, b.errable);
		}


		public bool re(double a, double b)
		{
			return re(new Ext4dbl( a),new Ext4dbl( b) );
		}


		static public ByBe CreateByAbs(double x) {
			return new ByBe(
				nilnul.num.real_.nonneg.coerce_._AbsX.Doub(x)
			);
		}


		static public ByBe OfUnital(double x) {
			return new ByBe(
				1/x
			);
		}

		static public ByBe OfTenth() {
			return OfUnital(10);
		}

		static public ByBe OfHundredth() {
			return OfUnital(100);
		}

		static public ByBe OfThousandth() {
			return OfUnital(1000);
		}

		static public ByBe OfMillionth() {
			return OfUnital(1000_000);
		}


		//static public ByBe Injected = new ByBe(  be_.small_.ByInjected4Dbl.Singleton.injected);
		



	}
}
