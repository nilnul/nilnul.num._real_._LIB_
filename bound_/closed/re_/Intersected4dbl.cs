using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed.re_
{
	/// <summary>
	/// share at least one point
	/// </summary>
	public class Intersected4dbl
		:
		re.complement_.ReNeo4Dbl<Disjoint4dbl>
		,
		closed.Re4dblI
	{


		static public Intersected4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Intersected4dbl>.Instance;
			}
		}

	}
}
