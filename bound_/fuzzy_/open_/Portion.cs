using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_
{
	/// <summary>
	/// portion is positive, so it's gt 0. portion is not proportion, so it doesnot reach 1.
	/// </summary>
	/// alias:
	///		portion
	///			positive.
	///	vs:
	///		ratio
	///			(-inf, inf)
	///			where first letter "r" implies all "r"eal.
	/// 
	public class Portion4dbl : bound_.Open4dbl
		,
		IUnital
	{
		public Portion4dbl() : base(0, 1)
		{
		}


		static public Portion4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Portion4dbl>.Instance;
			}
		}

	}
}
