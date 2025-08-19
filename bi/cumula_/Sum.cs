using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.binary.cumulator_
{
	public class Sum :
			 Cumulator_opDefault<nilnul.num.real.op_.binary_.Add>
		

	{
		public Sum() : base(new nilnul.num.real_.Quotient())
		{
		}

		static public Sum Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sum>.Instance;
			}
		}

	}
}
