using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;
using nilnul.num.quotient_;
using N = nilnul.num.quotient_.denomNonnil_.Nonneg;

namespace nilnul.num.real.re_.approx_
{
	/// <summary>
	/// symmectric
	/// reflexive
	/// not transitive
	/// </summary>
	public class Ratio1 
		:
		nilnul.obj.Box_ofIn<nilnul.num.quotient_.denomNonnil_.Nonneg>
		,
		nilnul.num.real.ReI_onQuotient
	{

		public Ratio1(nilnul.num.quotient_.denomNonnil_.Nonneg val) : base(val)
		{
		}

		public Ratio1(Q4 denomNonnil):this(new N(denomNonnil))
		{
		}
		

		public Ratio1(int i) : this(new  N (i))
		{
		}

	

		public Ratio1():this(0)
		{

		}




		static public Ratio1 OfUnital(int x) {
			return new Ratio1(
				num.quotient_.DenomNonnil.Inverse(x)
			);
		}

		static public Ratio1 OfTenth() {
			return OfUnital(10);
		}

		static public Ratio1 OfHundredth() {
			return OfUnital(100);
		}

		static public Ratio1 OfThousandth() {
			return OfUnital(1000);
		}

		static public Ratio1 OfMillionth() {
			return OfUnital(1000_000);
		}
		public bool re(Real_onQuotient a, Real_onQuotient b)
		{
			var aSq = a * a;
			var bSq = b * b;
			var s = aSq.ToImpl() + bSq;
			Real_onQuotient potence = s.ToImpl();

			if (potence <= boxed)
			{
				return true;
			}


			var dif = a - b;
			var difSq = dif.ToImpl() * dif;

			//var ab = a * b;
			//var difSq = s -ab;

			return difSq.ToImpl() <= boxed * potence;


			var abs = nilnul.num.real.op_.Abs.Singleton.op(a);
			var abs1 = nilnul.num.real.op_.Abs.Singleton.op(b);
			var absMin = nilnul.num.real.of_.binary_.Min.Singleton.op(abs, abs1);

			var distance = nilnul.num.real.co._DistanceX.Distance(a,b);

			return distance.ToImpl() <= absMin.ToImpl() * boxed;

		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool re(R0 a, R0 b)
		{
			

			return re(a.ToImpl(),b.ToImpl());


			var abs = nilnul.num.real.op_.Abs.Singleton.op(a);
			var abs1 = nilnul.num.real.op_.Abs.Singleton.op(b);
			var absMin = nilnul.num.real.of_.binary_.Min.Singleton.op(abs, abs1);

			var distance = nilnul.num.real.co._DistanceX.Distance(a,b);

			return distance.ToImpl() <= absMin.ToImpl() * boxed;

		}
		public bool re(nilnul.num.real_.Quotient_denomNonnil a, R0 b)
		{
			return re( (R0)(a),b ); ;

		}

		public bool re(nilnul.num.quotient_.DenomNonnil a, R0 b)
		{
			return re( new nilnul.num.real_.Quotient_denomNonnil(a),b ); ;

		}



		static public Ratio1 Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Ratio1>.Instance;
			}
		}



	}
}
