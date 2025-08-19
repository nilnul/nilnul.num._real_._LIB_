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
	/// proportion
	///		promoted from portion, so it can reach one.
	public class Proportion4dbl : bound_.OpenClose4Dbl
		,
		IUnital
	{
		public Proportion4dbl() : base(0, 1)
		{
		}


		static public Proportion4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Proportion4dbl>.Instance;
			}
		}

	}
}
