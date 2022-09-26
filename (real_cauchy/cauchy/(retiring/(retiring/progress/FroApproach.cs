﻿using nilnul.num._real.limit.sow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num._real.progress
{


	public class FroApproach<T> : ProgressI
		where T:ApproachI1, new()
	{


		static public readonly FroApproach<T> Singleton = SingletonByDefault<FroApproach<T>>.Instance;



		

		public ApproachI1 squeeze()
		{
				return new T();

			throw new NotImplementedException();
		}
	}

	static public class SingletonX {
		static public FroApproach<T> ToSingleton<T>(this T limit)
			where T:ApproachI1,new()
		{
			return FroApproach<T>.Singleton;
		}

	}
}
