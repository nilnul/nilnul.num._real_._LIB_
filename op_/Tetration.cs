using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_
{
	/// a+n
	/// a*n
	/// a^n = a**n
	/// a***n
	/// <summary>
	/// hyper4, 
	/// </summary>
	/// <remarks>
	/// a^b^c = a^(b^c), not (a^b)^c
	/// </remarks>
	/// 
	/// hyperOperation
	/// alias:
	///		tetration:tetra and iteration, implying 4 as greek, namely: +*^
	public class Tetration : nilnul.obj.Box_ofIn<nilnul.Num_ofIn>
		,
		nilnul.num.real.Op8dblI
	{
		public Tetration(in Num_ofIn val) : base(val)
		{
		}

		public Tetration(Num_ofIn x) : base(x)
		{
		}


		public double op(in double obj)
		{
			var bigint = this.boxed.eeByRef;
			if (bigint ==0 )
			{
				return 1;
			}
			return Math.Pow(
				obj,

			);

		}
	}
}
