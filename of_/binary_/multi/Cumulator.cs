using nilnul.obj.op_;
using nilnul.obj.op_.binary._cumulator_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.binary_.multi
{
	[Obsolete()]
	public class Cumulator:
		nilnul.obj.op_.binary.Accumulator_opDefault<RealI, Multi>
		

	{
		public Cumulator() : base(new nilnul.num.real_.Quotient(1))
		{
		}

		static public Cumulator Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Cumulator>.Instance;
			}
		}

	
	}
}
