using nilnul.num._real.limit.sow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num._real.approach._sow;

namespace nilnul.num._real.cofinal
{
	public class FroSqueeze<T>
		:
		Singleton
		where T:_real.SqueezeI,new()
	{

		static public readonly FroSqueeze<T> Singleton = SingletonByDefault<FroSqueeze<T>>.Instance;

		public FroSqueeze()
			
			:base(_real.approach.FroSqueeze<T>.Singleton)
		{

		}

	}

	static public class FroSqueezeX {
		static public FroSqueeze<T> ToSingleton<T>(this T limit)
			where T:_real.SqueezeI,new()

		{
			return  FroSqueeze<T>.Singleton;
		}

	}
}
