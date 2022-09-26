using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;
using nilnul.num.quotient_;

namespace nilnul.num.real.re_.approx_
{
	/// <summary>
	/// </summary>
	public class OnBeNil 
		:
		nilnul.obj.Box1<nilnul.num.real.be_.AboutNil4Dbl>
		,
		nilnul.num.real.ReDblI
	{
		public OnBeNil(be_.AboutNil4Dbl val) : base(  val) 
		{
		}

		public OnBeNil(nilnul.num.real_.NonnegOfDouble val) : base( new be_.AboutNil4Dbl( val) )
		{
		}


		

		public OnBeNil(int i) : this(new real_.NonnegOfDouble(i))
		{
		}

		public OnBeNil(double x) : this(
			new real_.NonnegOfDouble(x)
		)
		{

		}

		

		public bool re(double a, double b)
		{
			return boxed.be(a - b);
		}


		static public OnBeNil CreateByAbs(double x) {
			return new OnBeNil(
				nilnul.num.real_.nonneg.coerce_._AbsX.Doub(x)
			);
		}


		static public OnBeNil OfUnital(double x) {
			return new OnBeNil(
				1/x
			);
		}

		static public OnBeNil OfTenth() {
			return OfUnital(10);
		}

		static public OnBeNil OfHundredth() {
			return OfUnital(100);
		}

		static public OnBeNil OfThousandth() {
			return OfUnital(1000);
		}

		static public OnBeNil OfMillionth() {
			return OfUnital(1000_000);
		}


		static public OnBeNil Injected = new OnBeNil(  be_.AboutNil4Dbl.Injected);
		



	}
}
