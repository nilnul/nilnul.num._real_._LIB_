using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec_.tro_.unital_.axisal_
{
	public class Eks4dbl
		:
		nilnul.obj.vec_.Tro<double>
		,
		nilnul.num.real.vec_.ITro

	{
		public Eks4dbl() : base(1, 0, 0)
		{
		}

		static public Eks4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eks4dbl>.Instance;
			}
		}

	}
}
