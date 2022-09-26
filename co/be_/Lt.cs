using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


namespace nilnul.num.real.co.be_
{
	public class Lt : BeI
	{
		public bool be(Co obj )
		{
			return be(  obj as Tuple<R,R>);
 		}

		public bool be(R a, R b) {
			return be(new Co(a,b));
		}

		public bool be(Tuple<num.RealI, num.RealI> obj)
		{
			return nilnul.num.real.comp.Re.Singleton.lt(obj.Item1,obj.Item2);
		}


		static private Lazy<Lt> _Lazy = new Lazy<Lt>();
		static public Lt Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

		public class En : nilnul.num.real.co.be.En
		{
			public En( Co val) : base(Lazy, val)
			{

			}
		}

	}
}
