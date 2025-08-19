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
	public class Open4dbl : bound_.Open4dbl
		,
		IUnial
	{
		public Open4dbl() : base(-1, 1)
		{
		}


		static public Open4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Open4dbl>.Instance;
			}
		}

	}
}
