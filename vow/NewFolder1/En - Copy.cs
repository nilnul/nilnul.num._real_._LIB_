﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vow
{
	[Obsolete()]
	public class En<TVow> : nilnul.obj.vow.En<nilnul.num.RealI, TVow>
		where TVow : nilnul.num.real.VowI, new()
	{
		public En(num.RealI val) : base(val)
		{
		}
	}
}
