using nilnul.num._real.limit.sow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num._real.approach.generator.eg
{


	public class ApproachNew<T> : GeneratorI
		where T:ApproachI1, new()
	{


		static public readonly ApproachNew<T> Singleton = SingletonByDefault<ApproachNew<T>>.Instance;



		

		public ApproachI1 generate()
		{
				return new T();

			throw new NotImplementedException();
		}
	}

	static public class SingletonX {
		static public ApproachNew<T> ToSingleton<T>(this T limit)
			where T:ApproachI1,new()
		{
			return ApproachNew<T>.Singleton;
		}

	}
}
