using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._real.approach;
namespace nilnul.num._real.approach_.nonzero.op_._inverse
{
	[MayPerpetual]
	public class ShiftFroZero
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_real_nonZero"></param>
		/// <returns></returns>
		static public void Eval(ApproachI1 _real_nonZero)
		{

			var range = _real_nonZero.bound;

			while (range.lower.mark == 0 || range.upper.mark == 0)
			{



				_real_nonZero.Clamp1K();

				range = _real_nonZero.bound;
			}



		}

		static public void Proc(approach.be_.Nonzero.En real_nonZero)
		{

			var range = real_nonZero.val.bound;

			while (range.lower.mark == 0 || range.upper.mark == 0)
			{



				real_nonZero.val.Clamp1K();

				range = real_nonZero.val.bound;
			}



		}




	}
}
