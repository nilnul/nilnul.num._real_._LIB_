using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


namespace nilnul.num.real.re_
{
	public class Ge : ReI
	{
		public bool re(Real a, Real b)
		{
			return

				nilnul.num.real.be_.Nonneg.Singleton.be(a - b);
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
			return a >= b;
		}

		public bool be(Tuple<num.RealI, num.RealI> obj)
		{
			return re(obj.Item1,obj.Item2);
		}


		static private Lazy<Ge> _Lazy = new Lazy<Ge>();
		static public Ge Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

		

	}
}
