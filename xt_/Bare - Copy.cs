using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI2;


namespace nilnul.num.real.ext_
{
	public class Bare
		: nilnul.ext_.Bare<R>
		,
		ExtI
	{
		public Bare(R val) : base(val)
		{
		}
	}
}
