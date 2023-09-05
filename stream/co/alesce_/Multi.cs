using nilnul.num.real.stream_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.co.alesce_
{
	public class Multi : Alesce
	{
		public Multi(Co co) : base(co, real.combine_.Multi.Singleton)
		{
		}

		public Multi(real.StreamI rigid, real.StreamI multi):this(new Co(rigid,multi))
		{
		}
	}
}
