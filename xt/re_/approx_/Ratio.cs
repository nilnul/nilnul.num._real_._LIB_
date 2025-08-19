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
	public class Ratio 
		:
		nilnul.obj.Box<nilnul.num.real_.NonnegOfDoubleI>
		,
		nilnul.num.real.ext.Re4dblI
		,
		re_._assumesExt_.AssumeExts4DblI
	{

		//private nilnul.num.real.be_.AbsLeDbl _ratio;
		private nilnul.num.real_.NonnegOfDoubleI _ratio;
		public Ratio(nilnul.num.real_.NonnegOfDouble val) : base(val)
		{
			_ratio = val;
		}

		

		public Ratio(int i) : this(new real_.NonnegOfDouble(i))
		{
		}

		public Ratio(double x) : this(
			new real_.NonnegOfDouble(x)
		)
		{

		}

		public Ratio():this(double.Epsilon)
		{

		}
		public bool _re_01ext(double a, double b)
		{
			
			var abs = Math.Abs(a);
			var abs1 = Math.Abs(b);
			var absMin = Math.Min(abs, abs1);


			var distance =ext.of_.binary_.Distance.Singleton._op_01ext( a, b );
			return distance<= absMin* _ratio.realee.ee ;
		}

	

		public  bool re(Ext4dblI a, Ext4dblI b)
		{
			return _re_01ext(a.errable, b.errable);
		}
		public bool re(double a, double b)
		{
			var abs = Math.Abs(a);
			var abs1 = Math.Abs(b);
			var absMin = Math.Min(abs, abs1);

			var distance =Math.Abs( a - b );
			return distance<= absMin* _ratio.realee.ee ;
		}


		static public Ratio CreateByAbs(double x) {
			return new Ratio(
				nilnul.num.real_.nonneg.coerce_._AbsX.Doub(x)
			);
		}


		static public Ratio OfUnital(double x) {
			return new Ratio(
				1/x
			);
		}

		static public Ratio OfTenth() {
			return OfUnital(10);
		}

		static public Ratio OfHundredth() {
			return OfUnital(100);
		}

		static public Ratio OfThousandth() {
			return OfUnital(1000);
		}

		static public Ratio OfMillionth() {
			return OfUnital(1000_000);
		}


		static public Ratio Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Ratio>.Instance;
			}
		}



	}
}
