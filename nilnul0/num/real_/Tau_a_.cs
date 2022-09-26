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
using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient.all;
using nilnul.num.quotient_;
using q = nilnul.num.quotient;

namespace nilnul.num.real_
{
	/// <summary>
	/// a turn.
	/// using:
	/// Sum[(1/16^k) (4/(8 k + 1) - 2/(8 k + 4) - 1/(8 k + 5) - 1/(8 k + 6)), {k, 0, Infinity}]
	/// </summary>
	public class Tau :
		nilnul.obj.Box<_tau.Cumulus>
		,
		RealI
	{






		private readonly Q1 _residueUpperBound_multiplier   //  amplify each items 'cuz this is the upper bound
			= (4        //    8 / (8k+2) , let k=0
			+ (4).QDiv(3)   //4/(8k+3)	, let k=0
			+ 1     //  4/(8k+4)
					// - 1/ (8k+7)	, let this be zero
			) /

			(1 - (16).Inverse())    /// the geometry stream's rate is 1/16

			// the head of the remaining stream amplified:  1/16^(k+1)

			;

		public Tau() : base(new _tau.Cumulus())
		{
			///this is irrational, so the rational border can be excluded.
			_bound =new q.bound_.Closed(
					boxed.current,
					 boxed.current + _residueUpperBound_multiplier * boxed.nextAugend
					);
		}

		private q.bound_.Closed _bound;
		public q.bound_.Closed current
		{
			get
			{
				/// sum up the tail stream by amplifying the terms.
				return _bound;

			}
		}


		public void squeeze(num.quotient_.Positive1 diameter)
		{
			while (_bound.isNotDiameterLt(diameter))
			{
				boxed.moveNext();
				_bound = nilnul.num.quotient.bound_.closed.co_.joint._IntersectX.Intersect(
					_bound
					,
					new q.bound_.Closed(
						boxed.current,
						 boxed.current + _residueUpperBound_multiplier * boxed.nextAugend
					)
				);
			}

		}

		static public Tau Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Tau>.Instance;
			}
		}

	}
}