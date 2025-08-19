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

namespace nilnul.num._real.approach_
{
	/// <summary>
	/// Sum[(1/16^k) (4/(8 k + 1) - 2/(8 k + 4) - 1/(8 k + 5) - 1/(8 k + 6)), {k, 0, Infinity}]

	/// </summary>
	/// 
	[Obsolete("use A")]
	public class Tau1 : ApproachI1
	{
		private _tau.Series _series;

		public _tau.Series series
		{
			get { return _series; }
			set { _series = value; }
		}




		private Q1 _residueUpperBound = nilnul.num.quotient.all.X.QDiv( (128),(3 * 16)); // new Q1(128, 3) / 16;


		public Bound2 bound
		{
			get
			{
				/// sum up the tail stream by amplifying the terms.
				return Bound2.CreateOpen(_series.accumulated,
					 _series.accumulated + _residueUpperBound);


			}
		}

		public void clamp(Positive1.En diameter)
		{

			_series.moveNext();

			_residueUpperBound /= 16;

		}
	}
}
