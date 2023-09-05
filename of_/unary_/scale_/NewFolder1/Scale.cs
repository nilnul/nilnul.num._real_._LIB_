using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.RealI2;
namespace nilnul.num._real.approach.op_
{
	static public class _ScaleX
	{

		static public ApproachI1 Scale(this ApproachI1 r, Q scale) {

			if (scale==0)
			{
				return new nilnul.num._real.approach_.Quotient();

			}
			return new _scale._Ret_scaleNotZero(scale,r);

		}


		static public ApproachI1 Half(this ApproachI1 r) {

			return Scale(r, Q.CreateHalf());

		}



		
	}
}
