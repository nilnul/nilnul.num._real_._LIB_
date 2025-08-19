using nilnul.obj.of_.binary._cumulator_;
using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bi_.mul
{
	public class Cumula8dbl:
		
		nilnul.num.real.bi.cumula_.OpDefault8dbl<bi_.Multi8dbl>

	{
		public Cumula8dbl() : base(1)
		{
		}

		static public Cumula8dbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Cumula8dbl>.Instance;
			}
		}

	}
}
