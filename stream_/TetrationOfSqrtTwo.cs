using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._stream;

using R = nilnul.num.RealI;

namespace nilnul.num.real.stream_
{
	/// <summary>
	/// √2(√2√2 ...)
	/// 
	/// 
	/// 
	/// 
	/// Suppose instead we solve for x in x^x^x^... = 4?

	//By your method: x^x^x^... = x^(x^x^x^...) = x^4 = 4. So x = sqrt(2).

	//By your original result, when x = sqrt(2), x^x^x^... = 2. Therefore 4 = 2. QED.


	//let x:=sqrt(2) , and a :=1, x^1, x^x, x^(x^x), ....then a is bounded in that if a[n] <2, then a[n + 1] = x ^ a[n] < 2.also a is increasing monotonically.So a has a limit.This limit cannot be 4, 'cuz 4 is over the upper bound.Is it 2?The limit is somewhere between (sqrt(2), 2).If you suppose it's two, then the video is right.but first You have to prove it's two; that's the missing part of the video.
	/// </summary>
	public class TetrationOfSqrtTwo
		: nilnul.num.real.StreamI
	{

		static public readonly R SqrtTwo = 
			nilnul.num.real_.nonneg.op_.unary_._SqrtX.Real_assumePositive(2)
			;

		private R _pre= SqrtTwo;

		public R pre
		{
			get { return _pre; }
			//set { _pre = value; }
		}


		public R next()
		{
			return _pre= 
				nilnul.num.real.co_.starT_.positive._PowX.RetRealI( SqrtTwo, _pre )
				;
		}

		
	}
}
