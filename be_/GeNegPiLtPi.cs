﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;

namespace nilnul.num.real.be_
{
	public class GeNegPiLtPi
		:
		BeA,
		nilnul.num.real.BeI
	{
		public override bool be(Real x)
		{
			return x < num.real_.TauX.Half
				&&
				x>= -num.real_.TauX.Quarter;
		}

		static public GeNegPiLtPi Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<GeNegPiLtPi>.Instance;
			}
		}

	}
}
