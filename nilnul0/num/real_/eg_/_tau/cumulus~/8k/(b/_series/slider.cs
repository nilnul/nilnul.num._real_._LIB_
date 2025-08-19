using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using System.Numerics;
using nilnul.num.quotient.all;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num._real.approach_._tau._series
{
	/// <summary>
	/// (1/16^k) (
	///		4/(8 k + 1) 
	///		-
	///		2/(8 k + 4) 
	///		- 
	///		1/(8 k + 5) 
	///		- 
	///		1/(8 k + 6)
	///	)
	/// 
	/// , {k, 0, Infinity}
	/// </summary>
	/// 
	[Obsolete("use _a, which addes all terms")]
	public class Slider : nilnul.num.quotient.SliderI
	{

		private BigInteger _8kPlus4_ = 4;
		private BigInteger _8kPlus5_ = 5;
		private BigInteger _8kPlus6_ = 6;
		private BigInteger _8kPlus1_ = 1;

		//private BigInteger _16PowK = 1;//double to make tau from pi 

		private Q1 coefficent = 2; // 2/ 16^k



		public Simplify.Ed1 current
		{
			get
			{

				return coefficent * (
					nilnul.num.quotient.all.X.QDiv(
					(4), (_8kPlus1_))
					-
					nilnul.num.quotient.all.X.QDiv(

					(2), (_8kPlus4_))

					-
					nilnul.num.quotient.all.X.Inverse(

					_8kPlus5_)
					-
					nilnul.num.quotient.all.X.Inverse(

					_8kPlus6_
					)

				);

			}
		}



		public void moveNext()
		{
			//_16PowK *= 16;
			coefficent /= 16;

			_8kPlus1_ += 8;
			_8kPlus4_ += 8;
			_8kPlus5_ += 8;
			_8kPlus6_ += 8;
		}
	}
}
