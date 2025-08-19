using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using q = nilnul.num.quotient;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num.quotient_;
using nilnul.obj.stream_._slider._skid_;
using nilnul.num.quotient.co.diameter;
using nilnul.num.quotient.clamp;


namespace nilnul.num.real_.eg_
{
	/// <summary>
	/// the base for natural logarithm;
	/// 2.718281828459
	/// </summary>
	/// alias:
	///		exp
	///		euler
	///			<see cref="IEuler"/>
	public class Exp_onSubsume
		:
		nilnul.obj.box_.OfNew<nilnul.num.integer.stream_.slider_.peek_.positive.factorial.inverse.subsume_.Add>
		,
		nilnul.num.RealI_onQuotient

	{

		/// <summary>
		/// 
		/// </summary>
		public Exp_onSubsume() : base(

		)
		{

			_bound = (
				1,
				3	// 1 + 1/ (1-1/2)
			); // series current is 1/0!

			boxed.moveNext(); // for the next computation of bound.

		}

		private (Q4 begin, Q4 end) _bound;
		public (Q4 begin, Q4 end) current => _bound;

		public void cinch(num.quotient_.denomNonnil_.Positive diameter)
		{
			(Q4 begin, Q4 end) t = _bound;

			while (
				t.DiameterGt(diameter)
			)
			{

				var index = this.boxed.indexAhead; // 2

				var c = this.boxed.current; /// now this is 1/0!+1/1!, per 1/0! + 1/1! + 1/2 +1/6 + ... + 1/n!

				boxed.moveNext();

				t = (
					c 
					,
					c +  new DenomNonnil(
						this.boxed.indexAhead	// 3
						,
						index * this.boxed.denominator //	2*2
					)
				///
				///		1/(n+1)!    /  ( 1 -    1/(n+2)   )
				///		= 1/(n+1)!    /  ( (n+1) /(n+2)   ) = 1 / (n+1)! * ( (n+2) / (n+1) )
				///										= 1 / (n+1)! * ( 1+ 1 / (n+1) )
				///		= (n+2) / ( (n+1) *(n+1)! )
				///	, note we need n 
				///
				///  the end for current:
				/// 1+1+ 1/2 +1/6 + ... + 1/n!
				/// + 1 / (n+1)! * ( 1+ 1 / (n+1) )
				///  
				/// for the next round :
				///
				/// 1+1+ 1/2 +1/6 + ... + 1/n! + 1 / (n+1)!
				///  + 1 / (n+2)! * ( 1+ 1 / (n+2) )
				///  
				/// the latter - the previous
				/// = 1 / (n+1)!  + 1 / (n+2)! * ( 1+ 1 / (n+2) )
				///		-(
				///			1 / (n+1)! * ( 1+ 1 / (n+1) )
				///		)
				///	=1 / (n+2)! * ( 1+ 1 / (n+2) )
				///		-(
				///			1 / (n+1)! * (  1 / (n+1) )
				///		)
				///	=  ( (n+3) / (n+2) )/ (n+2)!
				///	-
				///		1 / ( (n+1)! * (n+1)  )
				///		
				///	=   (n+3)/ ((n+2)!(n+2) )
				///		-
				///		1 / ( (n+1)! * (n+1)  )
				///		
				///	=   (n+3)/ ((n+2)(n+1)!(n+2) )
				///		-
				///		1 / ( (n+1)! * (n+1)  )
				///		
				///	=  1/(n+1)! *  (
				///		(n+3)/ ((n+2)(n+2) )
				///		-
				///		1 /   (n+1)
				///	)
				///	where
				///		
				///	
				///		(n+3)/ ( (n+2)(n+2) )
				///		-
				///		1 / (n+1)
				///	
				///	=
				///		( (n+3)(n+1) - (n+2)*(n+2) )
				///		/
				///		( (n+2) (n+2) (n+1) )
				///	,which is always negative.
				///	, note when n=-1, the above is (0-1) /0, and we cannot say it's negative.
				);
			}
			_bound = t;
		}


		static public Exp_onSubsume Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Exp_onSubsume>.Instance;
			}
		}



	}

	/*
	 事物发展的两个典型模式
1，变化速度与存量成正比，这个是指数模式，与e相关
2，回复加速度与偏离成正比, 方向相反；这个震荡模式，与π相关
	 * 
	 * ****/

}
