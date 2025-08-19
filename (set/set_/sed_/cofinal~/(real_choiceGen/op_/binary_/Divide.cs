using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op_.binary_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// <seealso cref="nameof(nilnul.num.real.co_.divisible.bind_._DivX)"/></remarks>
	public  class Divide:BinaryI2
	{
	

		public RealI6 op(RealI6 par, RealI6 par1)
		{
			return Multi1.Singleton.op(
				par
				,
				op_.unary_.Inverse.Singleton.op(par1)
			);

		}


		static public Divide Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Divide>.Instance;
			}
		}

	}
}
