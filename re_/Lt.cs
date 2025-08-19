using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


namespace nilnul.num.real.re_
{
	public class Lt : ReI
		,
		real.ReI_onQuotient
	{
		public bool re(Real a, Real b) {
			return				nilnul.num.real.be_.Negative.Singleton.be(a-b);
		}
		public bool re(Real_onQuotient a, RealI_onQuotient b) {
			return	nilnul.num.real.be_.Negative.Singleton.be(a-b);
		}

		public bool re(RealI_onQuotient a, Real_onQuotient b) {
			return	nilnul.num.real.be_.Negative.Singleton.be(a-b);
		}
		public bool re(Real_onQuotient a, Real_onQuotient b) {
			return	nilnul.num.real.be_.Negative.Singleton.be(a-b);
		}


		public bool re(R0 a, R0 b) {
			return	re( a.ToImpl(), b);
		}

		public bool re(R a, R b) {
			return		re( Real.Ov(a), Real.Ov(b));
		}


		public bool be(Tuple<num.RealI, num.RealI> obj)
		{
			return re(obj.Item1,obj.Item2);
		}

		public bool be(Co obj )
		{
			return re(  obj.Item1,obj.Item2);
 		}




		static public Lt Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Lt>.Instance;
			}
		}



		static public Lt Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Lt>.Instance;
			}
		}

		public bool re(Real a, PositiveI b)
		{
			return nilnul.num.real.be_.Negative.Singleton.be(a - b.en.en);

		}

	

		public bool re(Real_onQuotient a, quotient_.denomNonnil_.Positive b)
		{
			return nilnul.num.real.be_.Negative.Singleton.be(a - b.eeByRef);

		}
	}
}
