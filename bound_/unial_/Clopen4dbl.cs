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
	public class Clopen4dbl : bound_.Open4dbl
		,
		IUnial
	{
		public Clopen4dbl() : base(-1, 1)
		{
		}


		static public Clopen4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Clopen4dbl>.Instance;
			}
		}

	}
}
