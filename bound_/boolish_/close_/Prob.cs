using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.unital_
{
	/// <summary>
	/// for probability
	/// </summary>
	/// <remarks>
	/// alias:
	///		proportion
	///		percentage
	///			but percentage can go beyond the bound
	///		progression
	///		potence
	///		
	/// </remarks>
	public class Prob4dbl : bound_.ClosedDbl
		,
		IUnital
	{
		public Prob4dbl() : base(0, 1)
		{
		}


		static public Prob4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Prob4dbl>.Instance;
			}
		}

	}
}
