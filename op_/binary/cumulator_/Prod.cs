using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.binary.cumulator_
{
	public class Prod : Cumulator_opDefault<nilnul.num.real.op_.binary_.Multi>
	{
		public Prod() : base(new nilnul.num.real_.Quotient(1))
		{
		}

		static public Prod Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Prod>.Instance;
			}
		}

	}
}
