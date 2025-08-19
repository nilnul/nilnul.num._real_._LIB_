using nilnul.num._real.limit.sow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num._real.approach._sow;

namespace nilnul.num._real.approach.generator.cofinal.eg.single.generatorNew
{
	public class FroApproach<T>
		:
		Singleton
		where T:_real.ApproachI1,new()
	{

		static public readonly FroApproach<T> Singleton = SingletonByDefault<FroApproach<T>>.Instance;

		public FroApproach()
			
			:base(_real.approach.generator.eg.ApproachNew<T>.Singleton)
		{

		}

	}

	static public class FroSqueezeX {
		static public FroApproach<T> ToSingleton<T>(this T limit)
			where T:_real.ApproachI1,new()

		{
			return  FroApproach<T>.Singleton;
		}

	}
}
