using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;

namespace nilnul.num.real
{

	[PossibleException]
	[Obsolete()]
	public class Eq1 : IEqualityComparer<R>
	{

		static public bool Eval
			(R x, R y)
		{

			if( Object.ReferenceEquals(x, y))return true;

			return nilnul.num.real.be_.Zero.Be(
				nilnul.num.real.duo.op_.Minus.Singleton.eval(x,y)
				
			);



		}
		public bool Equals
			(R x, R y)
		{
			if( Object.ReferenceEquals(x, y))return true;

			return nilnul.num.real.be_.Zero.Be(
				nilnul.num.real.duo.op_.Minus.Singleton.eval(x,y)
				
			);

			//throw new NotImplementedException();
		}

		public int GetHashCode(R obj)
		{
			return 1;
			//throw new NotImplementedException();
		}


		static public readonly Eq1 Singleton = SingletonByDefault<Eq1>.Instance;

	}
}
