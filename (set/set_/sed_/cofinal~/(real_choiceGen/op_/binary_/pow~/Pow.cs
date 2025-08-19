using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CofinalI = nilnul.num.RealI2;
using R1 = nilnul.num.RealI2;
using Quotient2 = nilnul.num.real_.Quotient;

namespace nilnul.num.real.duo.op_._ret
{


	public class Pow :
		nilnul._call.argArg1_.Closed<CofinalI>
		,
		CofinalI
	{
		public Pow(CofinalI arg, CofinalI arg1) : base(arg, arg1)
		{
		}

		public GeneratorI choice
		{
			get
			{
				return new num._real.approach.generator.duo.op_.Multi.Ed(arg.choice, arg1.choice);
				throw new NotImplementedException();
			}
		}

		public override string ToString()
		{
			return $"{ arg}{ op_.Pow.Sign}{ arg1}";
		}
	}



}
