using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec_.tro_.unital_.axisal_.anti_
{
	public class Zed4dbl
		:
		nilnul.obj.vec_.Tro<double>
		,
		nilnul.num.real.vec_.ITro

	{
		public Zed4dbl() : base(0, 0, -1)
		{
		}

		static public Zed4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Zed4dbl>.Instance;
			}
		}

	}
}
