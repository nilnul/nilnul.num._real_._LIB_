using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CofinalI = nilnul.num.RealI2;

namespace nilnul.num.real.duo.op_._add
{
	
	[Obsolete()]
		public class Call :
			nilnul._call.argArg1_.Closed<CofinalI>
			,
			CofinalI
		{
			public Call(CofinalI arg, CofinalI arg1) : base(arg, arg1)
			{
			}

			public GeneratorI choice
			{
				get
				{
					return new num._real.approach.generator.duo.op_.Add.Ed(arg.choice,arg1.choice);
					throw new NotImplementedException();
				}
			}

			public override string ToString()
			{
				return $"{ arg}{ Add.Sign}{ arg1}";
			}
		
	}
}
