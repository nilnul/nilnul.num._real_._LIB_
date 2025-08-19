using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;


namespace nilnul.num.real.op_._cube
{

	[Obsolete()]
	public class Call
: Arg
, R
	{
		public Call(R arg) : base(arg)
		{

		}

		public GeneratorI choice
		{
			get
			{
				return new nilnul.num._real.approach.generator.op_._cube.Call(arg.choice);

				throw new NotImplementedException();
			}
		}
		public override string ToString()
		{
			return $"({arg})^3";
		}
	}


}
