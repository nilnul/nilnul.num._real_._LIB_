using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using R = nilnul.num.RealI2;
using nilnul.num._real.approach.generator.op_._negate;

namespace nilnul.num.real.op_._ret
{


	public class Sin
		: Arg
		, R
	{
		public Sin(R arg) : base(arg)
		{

		}

		public GeneratorI choice
		{
			get
			{

				throw new NotImplementedException();
			}
		}
	}
}
