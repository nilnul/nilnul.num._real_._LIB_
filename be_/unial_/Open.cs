﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;

namespace nilnul.num.real.be_.unial_
{
	/// <summary>
	/// (-1,1), a miniature mapping of (-inf, inf)
	/// </summary>
	public class Open
		:
		BeA,
		nilnul.num.real.BeI
	{
		public override bool be(Real x)
		{
			return x>-1 && x <1;
		}

		static public Open Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Open>.Instance;
			}
		}

	}
}