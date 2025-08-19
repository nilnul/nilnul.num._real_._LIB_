using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CofinalI = nilnul.num.RealI2;

namespace nilnul.num.real.duo.op_
{
	[Obsolete()]
	public class Minus
		: OpI
	{
		public const char Sign = '-';


		static public readonly Minus Singleton = SingletonByDefault<Minus>.Instance;


		public CofinalI eval(CofinalI a, CofinalI b)
		{

			return new Ed(a, b);
			//throw new NotImplementedException();
		}
		public override string ToString()
		{
			return Sign.ToString();
		}

		public class Ed :
			nilnul._call.argArg1_.Closed<CofinalI>
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
					return new num._real.approach.generator.duo.op_.Minus.Ed(arg.choice,arg1.choice);
					throw new NotImplementedException();
				}
			}

			public override string ToString()
			{
				return $"{ arg}{ Minus.Sign}{ arg1}";
			}
		}
	}
}
