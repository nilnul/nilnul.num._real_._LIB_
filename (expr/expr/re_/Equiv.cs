using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr.re_
{
	/// <summary>
	/// 
	/// </summary>
	public class Equiv
		: nilnul.num.real.expr.ReI
	{
		public bool re(ExprI a, ExprI b)
		{
			throw new NotImplementedException();
		}


		static public Equiv Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Equiv>.Instance;
			}
		}

	}
}
