using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


namespace nilnul.num.real.re_
{
	public class Gt : ReI
	{
		public bool re(Real a, Real b)
		{
			return

				nilnul.num.real.be_.Positive.Singleton.be(a - b);
		}
		public bool re(R a, R b)
		{
			return

				re(Real.Ov(a), Real.Ov(b));
		}
		public bool be(Co obj )
		{
			return re(obj.Item1,obj.Item2);
 		}

		

		public bool re(decimal a, decimal b) {
			return a>b;
		}

		public bool be(Tuple<num.RealI, num.RealI> obj)
		{
			return re(obj.Item1,obj.Item2);
		}


		static private Lazy<Gt> _Lazy = new Lazy<Gt>();
		static public Gt Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}


		static public Gt Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Gt>.Instance;
			}
		}

		public bool re(Real a, PositiveI b)
		{
			return nilnul.num.real.be_.Positive.Singleton.be(a - b.en.en);

		}
	}
}
