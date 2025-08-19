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
	///		potential
	///		
	/// </remarks>
	public class Partial4dbl : bound_.Clopen4dbl
		,
		IUnital
	{
		public Partial4dbl() : base(0, 1)
		{
		}


		static public Partial4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Partial4dbl>.Instance;
			}
		}

	}
}
