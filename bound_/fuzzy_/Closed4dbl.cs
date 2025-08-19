using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.unial_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	public class Closed4dbl : bound_.ClosedDbl
		,
		IUnial
	{
		public Closed4dbl() : base(-1, 1)
		{
		}


		static public Closed4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Closed4dbl>.Instance;
			}
		}

	}
}
