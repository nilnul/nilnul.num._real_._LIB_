using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;

namespace nilnul.num.real.stream
{
	/// <summary>
	/// x-x^3/3!+x^5/5!
	/// </summary>
	/// 
	[Obsolete("",true)]
	public partial class SinX
	{
		private R _x;

		public R x
		{
			get { return _x; }
			set { _x = value; }
		}


		public R this[int i]{
			get{
				var odd = num.natural.stream.Odd.GetItem(i);

				return  nilnul.num.real.op.Multi_posConverge2bounded.Eval(  
					num.rational.op.DivideX.Eval4(
						num.i.stream.AlterOne.GetItem(i)
						,
						odd		//should be oddFactoral

				
					)
					,
					num.real.op.Pow_posConverge2interval.Eval(x,odd)
				)
				
				;
			}
		}


    }
}
