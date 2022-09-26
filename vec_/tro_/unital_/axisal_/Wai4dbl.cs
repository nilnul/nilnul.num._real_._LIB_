using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec_.tro_.unital_.axisal_
{
	public class Wai4dbl
		:
		nilnul.obj.vec_.Tro<double>
		,
		nilnul.num.real.vec_.ITro

	{
		public Wai4dbl() : base(0, 1, 0)
		{
		}

		static public Wai4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Wai4dbl>.Instance;
			}
		}

	}
}
