using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using Q = nilnul.num.rational.Rational_InheritFraction2;

using Bound2 = nilnul.num.quotient.border.duo.be_.Nonempty.En;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient.all;

namespace nilnul.num._real.approach_.tau_
{
	/// <summary>
	/// Sum[(1/16^k) (4/(8 k + 1) - 2/(8 k + 4) - 1/(8 k + 5) - 1/(8 k + 6)), {k, 0, Infinity}]

	/// </summary>
	public class Tau_a_ : ApproachI1
	{
		private _a.slider.stream.Series _series=new _a.slider.stream.Series();

		public _a.slider.stream.Series series
		{
			get { return _series; }
			//set { _series = value; }
		}





		private readonly Q1 _residueUpperBound_multiplier	//  amplify each items 'cuz this is the upper bound
			= ( 4		//    8 / (8k+2) , let k=0
			+ 
			nilnul.num.quotient.all.X.QDiv(
			(4),(3))	//4/(8k+3)	, let k=0
			+1		//  4/(8k+4)
					// - 1/ (8k+7)	, let this be zero
			) / 
			nilnul.num.quotient.all.X.Inverse(
			( 1- (16)
			))	/// the geometry stream's rate is 1/16
			
				// the head of the remaining stream amplified:  1/16^(k+1)
			
			;


		public Bound2 bound
		{
			get
			{
				/// sum up the tail stream by amplifying the terms.
				return Bound2.CreateOpen(_series.accumulated,
					 _series.accumulated + _residueUpperBound_multiplier * _series.coefficientComing);


			}
		}

		public void clamp(Positive1.En diameter)
		{
			while (bound.notSpanLessThan(diameter))
			{

				_series.moveNext();

			}


			

		}
	}
}
