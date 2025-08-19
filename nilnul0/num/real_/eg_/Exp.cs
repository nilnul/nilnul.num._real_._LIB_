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


namespace nilnul.num.real_
{
	/// <summary>
	/// the base for natural logarithm;
	/// 2.718281828459
	/// </summary>
	/// alias:
	///		exp
	///		euler
	///			<see cref="IEuler"/>
	public class Exp
		:
		nilnul.obj.box_.OfNew<_exp.Series>
		//nilnul.num.quotient.stream_.bound_.cauchy_.slider_.SliderSeriesA
		,
		nilnul.num.RealI_onQuotient

	{

		private nilnul.num.quotient.Bound _exp0_x;
		public nilnul.num.quotient.Bound exp0_x
		{
			get { return _exp0_x; }
			//set { _exp0_x = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public Exp() : base(

		)
		{
			_exp0_x = nilnul.num.quotient.Bound.CreateOpen(
				1,
				3
			);
			base.boxed.moveNext(); //

			_bound = (
				1,
				3	// 1 + 1/ (1-1/2)
			);

		}

		private (Q4 begin, Q4 end) _bound;
		public (Q4 begin, Q4 end) current => _bound;

		public void cinch(num.quotient_.denomNonnil_.Positive diameter)
		{
			while (
				current.DiameterGt(diameter)

			)
			{


				boxed.moveNext();
				ref var index = ref this.boxed.indexAhead;
				var indexPlus = index + 1;
				var indexPlus2 = indexPlus + 1;
				var c = this.boxed.current;


				_bound = (
					c//.accumulated ,it's 0 initally. 1+1+ 1/2 +1/6 + ... + 1/n!
					,

					c + indexPlus2 / (indexPlus) * this.boxed.toBeCumulated
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
		}


		static public Exp Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Exp>.Instance;
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
