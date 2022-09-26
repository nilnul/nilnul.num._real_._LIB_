using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.real_;
using R = nilnul.num.RealI3;


namespace nilnul.num.real
{
	[Obsolete()]
	public class Comparer1
		: IComparer<R>
	{
		//static public  Comparer Singleton = SingletonByDefault<Comparer>.Instance;

		private static Lazy<Comparer1> instance = new Lazy<Comparer1>();
		
		public static Comparer1 Singleton { get { return instance.Value; } }


		public int Compare(R x, R y)
		{
			return nilnul.num.real._SignX1.Int(
				nilnul.num.real.op_.binary_.Minus.Singleton.op(x, y)
			);
		}

	}


}
