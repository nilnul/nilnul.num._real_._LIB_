﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.nonneg.co.be_
{
	public class Gt4dbl
		:
		nonneg.co.Be4dblI
	{
		public bool be(CoDbl obj)
		{
			return obj.component.realee.ee > obj.component1.realee.ee;
			//throw new NotImplementedException();
		}


		static public Gt4dbl Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Gt4dbl>.Instance;
			}
		}
		static public Gt4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Gt4dbl>.Instance;
			}
		}


	}
}
