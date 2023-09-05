using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using Tail2 = nilnul.num.rational.be.Tail.Asserted;
using q = nilnul.num.quotient;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num._real.approach.op_._exp.ret_.ofQ_._ge0leOne
{
	/// <summary>
	/// the exponential of the "e", where the index is rational and is in the interval of [0,1)
	/// </summary>
	public class Ge0LeOne

		:
			ApproachI1
	{
		


		private _ge0LeOne.Series _series;

		public _ge0LeOne.Series series
		{
			get { return _series; }
			set { _series = value; }
		}


		public Ge0LeOne(q.be_.GeZeroLeOne.En index)
		{

			_series = new _ge0LeOne.Series(index);
		}

	



		

		public Nonempty.En bound
		{
			get
			{
				return Nonempty.En.CreateClose(
						_series.accumulated

#error "+ e^0 * _series.nextAugend"

						,
						_series.accumulated+ 3*_series.nextAugend
					);
				//throw new NotImplementedException();
			}
		}

		

		public void clamp(Positive1.En diameter)
		{


			while (
				bound.notSpanLessThan(diameter)
				
			)
			{
				_series.next();
			}

		}
	}
}
