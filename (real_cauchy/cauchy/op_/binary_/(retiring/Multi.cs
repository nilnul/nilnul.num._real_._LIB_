﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.num._real.approach.generator.duo.op_
{
	public class Multi
		:OpI
	{
		public const char Sign = '*';
		static public readonly Multi Singleton = SingletonByDefault<Multi>.Instance;

		public GeneratorI eval(GeneratorI a, GeneratorI b)
		{
			return new Ed(a, b);

			throw new NotImplementedException();
		}



		static public GeneratorI Square(GeneratorI a) {
			return Singleton.eval(a, a);
		}

		public class Ed : nilnul._call.argArg1_.Closed<GeneratorI>
			,GeneratorI
		{
			public Ed(GeneratorI arg, GeneratorI arg1) : base(arg, arg1)
			{


			}

			public ApproachI1 generate()
			{
				return _real.approach.duo.op_.Multi.Eval(arg.generate(),arg1.generate());

				throw new NotImplementedException();
			}
			public override string ToString()
			{
				return $"{arg}{Multi.Sign}{arg1}";
			}
		}

	}
}
