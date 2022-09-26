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
	public class Parture4dbl : bound_.OpenClose4Dbl
		,
		IUnial
	{
		public Parture4dbl() : base(-1, 1)
		{
		}


		static public Parture4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Parture4dbl>.Instance;
			}
		}

	}
}
