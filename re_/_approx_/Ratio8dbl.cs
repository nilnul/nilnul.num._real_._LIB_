using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;
using nilnul.num.quotient_;

namespace nilnul.num.real.re_.approx_
{
	/// <summary>
	/// for double;
	/// symmetric: as this takes the max as the denominator.
	/// reflexive
	/// not transitive
	/// </summary>
	/// 
	public class Ratio8dbl 
		:
		nilnul.obj.Box<nilnul.num.real_.NonnegOfDoubleI>
		,
		nilnul.num.real.re_.Approx4dblI
	{

		//private nilnul.num.real.be_.AbsLeDbl _ratio;
		private nilnul.num.real_.NonnegOfDoubleI _ratio;
		public nilnul.num.real_.NonnegOfDoubleI ratio {
			get {
				return _ratio;//.realee.ee;
			}
		}

		public Ratio8dbl(nilnul.num.real_.NonnegOfDouble val) : base(val)
		{
			_ratio = val;
		}

		

		public Ratio8dbl(int i) : this(new real_.NonnegOfDouble(i))
		{
		}

		public Ratio8dbl(double x) : this(
			new real_.NonnegOfDouble(x)
		)
		{

		}

		public Ratio8dbl():this(double.Epsilon)
		{

		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool _re_01unneg(double a, double b)
		{
			return re(a, b);
			return Math.Abs( a - b )/// if both are 0, this is 0; if one is 0, this is the bigger.
				<=
				 nilnul.num.real.bi_._MidX.Mid(a,b) 	/// if one is 0, this is half the bigger
				* _ratio.realee.ee ;    /// if one is 0,  a le a/2 * ratio; so when ration is lt 2, this will never be true.


		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool re(double a, double b)
		{
			var aSq = a * a;
			var bSq = b * b;
			var s = aSq + bSq;
			if (s<= _ratio.realee.ee)
			{
				return true;
			}


			var dif = a - b;
			var difSq = dif * dif;

			//var ab = a * b;
			//var difSq = s -ab;

			return difSq <= _ratio.realee.ee * s;



			return Math.Abs( a - b )/// the distance;  for (1.5,2), it's 3.5
				<=
				nilnul.num.real.bi_._MidX.Mid(Math.Abs(a), Math.Abs(b))	/// if the two are <see cref="nilnul.num.real.re_.Opposite"/> like (-1.5, 2), the this is 1.75, not .25 the mid
				* _ratio.realee.ee ;






			return Math.Abs( a - b )
				<=
				Math.Min(Math.Abs(a), Math.Abs(b))	/// if one is 0, this is 0;
				* _ratio.realee.ee ;	/// when one compared is 0, then the two must all be nil.
		}


		static public Ratio8dbl CreateByAbs(double x) {
			return new Ratio8dbl(
				nilnul.num.real_.nonneg.coerce_._AbsX.Doub(x)
			);
		}


		static public Ratio8dbl OfUnital(double x) {
			return new Ratio8dbl(
				1/x
			);
		}

		static public Ratio8dbl OfTenth() {
			return OfUnital(10);
		}

		static public Ratio8dbl OfHundredth() {
			return OfUnital(100);
		}

		static public Ratio8dbl OfThousandth() {
			return OfUnital(1000);
		}

		static public Ratio8dbl OfMillionth() {
			return OfUnital(1000_000);
		}


		static public Ratio8dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Ratio8dbl>.Instance;
			}
		}



	}
}
