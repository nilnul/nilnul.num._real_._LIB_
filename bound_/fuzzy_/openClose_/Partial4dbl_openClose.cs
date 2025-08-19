using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.unital_
{
	/// <summary>
	/// </summary>
	/// alias:
	///		partial
	///			like partial order, exclude 0, but include 1.
	///		parture
	///			like departure
	public class Partial4dbl_openClose : bound_.OpenClose4Dbl
		,
		IUnital
	{
		public Partial4dbl_openClose() : base(0, 1)
		{
		}


		static public Partial4dbl_openClose Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Partial4dbl_openClose>.Instance;
			}
		}

	}
}
