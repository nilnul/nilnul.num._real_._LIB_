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
	{
		public bool re(Real a, Real b) {
			return				nilnul.num.real.be_.Negative.Singleton.be(a-b);
		}
		public bool re(R a, R b) {
			return

				re( Real.Ov(a), Real.Ov(b));
		}

		public bool be(Tuple<num.RealI, num.RealI> obj)
		{
			return re(obj.Item1,obj.Item2);
		}

		public bool be(Co obj )
		{
			return re(  obj.Item1,obj.Item2);
 		}



		static private Lazy<Lt> _Lazy = new Lazy<Lt>();
		static public Lt Lazy
		{
			get
			{
				return _Lazy.Value;
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
	}
}
