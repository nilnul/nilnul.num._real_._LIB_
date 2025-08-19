using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.unital_
{
	/// <summary>
	/// partial is not whole, so it doesnot include 1.
	/// when you participate  a project, you are a member, or a nonmember observer (0-participance), but not a leader.
	/// 
	/// </summary>
	/// <remarks>
	/// pseudo random generates a number in this bound.
	/// alias:
	///		proportion
	///			like probability, includes 0.
	///		potential
	///		
	/// vs:
	///		rate,
	///			which is in [0, inf)
	///		
	/// </remarks>
	public class Proportion4dbl_clopen : bound_.Clopen4dbl
		,
		IUnital
		,
		normal_.IPotence
	{

		public Proportion4dbl_clopen() : base(0, 1)
		{
		}


		static public Proportion4dbl_clopen Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Proportion4dbl_clopen>.Instance;
			}
		}

	}
}
