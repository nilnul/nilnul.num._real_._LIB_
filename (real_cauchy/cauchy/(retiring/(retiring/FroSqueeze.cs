using nilnul.num._real.limit.sow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num._real.approach
{

	[Obsolete()]
	public class FroSqueeze<T> : ApproachI
		where T:SqueezeI, new()
	{


		static public readonly FroSqueeze<T> Singleton = SingletonByDefault<FroSqueeze<T>>.Instance;



		public SqueezeI converge()
		{
				return new T();

			throw new NotImplementedException();
		}
	}

	static public class SingletonX {
		static public FroSqueeze<T> ToSingleton<T>(this T limit)
			where T:SqueezeI,new()
		{
			return  FroSqueeze<T>.Singleton;
		}

	}
}
