using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach.generator.cofinal.duo.op_
{
	[Obsolete()]
	public class Multi
		: OpI
	{
		public const char Sign = '*';


		static public readonly Multi Singleton = SingletonByDefault<Multi>.Instance;


		public CofinalI eval(CofinalI a, CofinalI b)
		{

			throw new NotImplementedException();
		}
		public override string ToString()
		{
			return Sign.ToString();
		}

		public class Ed :
			_call.argArg1_.Closed<CofinalI>
			,
			CofinalI
		{
			public Ed(CofinalI arg, CofinalI arg1) : base(arg, arg1)
			{
			}

			public GeneratorI choice
			{
				get
				{
					return new generator.duo.op_.Multi.Ed(arg.choice,arg1.choice);
					throw new NotImplementedException();
				}
			}

			public override string ToString()
			{
				return $"{ arg}{ Multi.Sign}{ arg1}";
			}
		}
	}
}
