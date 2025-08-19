using nilnul.obj.op_;
using nilnul.obj.op_.binary._cumulator_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.binary_.multi
{
	public class Cumulator1:
		nilnul.obj.op_.binary.cumulator_.OpDefault<RealI, Multi>
		,
		real.op_.binary.CumulatorI1

	{
		public Cumulator1() : base(new nilnul.num.real_.Quotient(1))
		{
		}

		static public Cumulator1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Cumulator1>.Instance;
			}
		}

	}
}
