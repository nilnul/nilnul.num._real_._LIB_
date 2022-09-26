using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.real_;
using R = nilnul.num.RealI2;


namespace nilnul.num.real
{
	[Obsolete()]
	public class Comparer
		: IComparer<R>
	{

		//static public  Comparer Singleton = SingletonByDefault<Comparer>.Instance;



		private static Lazy<Comparer> instance = new Lazy<Comparer>();
		
		public static Comparer Singleton { get { return instance.Value; } }


		public int Compare(R x, R y)
		{
			return nilnul.num.RealX.Sign(
				duo.op_.Minus.Singleton.eval(x, y)
			);
		}

		public class Decider:nilnul.comparer.decider_.FroStatic1<R,Comparer>
		{

			static public readonly Decider Singleton = SingletonByDefault<Decider>.Instance;

			public bool ge(nilnul.num.Quotient real, nilnul.num.RealI2 real1)
			{
				return ge(new nilnul.num.real_.Quotient(real) , real1);

				//throw new NotImplementedException();
			}
		}
	}


}
