using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


namespace nilnul.num.real.re_
{
	public class Eq :
		nilnul.obj.re_.EqA<R>
		,
		ReI
		,
		nilnul.num.real.ReDblI
		,
		IEqualityComparer<double>
	{
		
		public override bool re(R x, R y)
		{
			if (Object.ReferenceEquals(x, y)) return true;

			return nilnul.num.real.be_.Nil.Singleton.be(
				nilnul.num.real.op_.binary_.Minus.Singleton.op(x, y)
			);
			;
		}
		public bool re(Co obj )
		{
			return re(obj.Item1,obj.Item2);
 		}

	

		public bool re(decimal a, decimal b) {
			return a == b;
		}
		public bool re(double a, double b) {
			return a == b;
		}


		public bool be(Tuple<num.RealI, num.RealI> obj)
		{
			return re(obj.Item1,obj.Item2);
		}

		public bool Equals(double x, double y)
		{
			return x==y;
		}

		public int GetHashCode(double obj)
		{
			return obj.GetHashCode();
		}

		static private Lazy<Eq> _Lazy = new Lazy<Eq>();
		static public Eq Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}


		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}




	}
}
