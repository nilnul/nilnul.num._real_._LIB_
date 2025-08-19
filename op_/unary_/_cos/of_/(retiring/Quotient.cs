using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num._real.approach.op_.uni_._cos.of_
{
	public class Quotient
		:
		nilnul.num._real.ApproachI1
	{
		private _quotient.Series _series;

		public _quotient.Series series
		{
			get { return _series; }
			//set { _series = value; }
		}


		public Quotient(Q1 arg) 
		{
			_series = new _quotient.Series(arg);
		}

		public Nonempty.En bound
		{
			get
			{
				return Nonempty.En._CreateCloseNeighbor_assertRadiusNoneg(
					  nilnul.num.quotient.op_.Abs.Eval( _series.nextAugend)	
				);
				//throw new NotImplementedException();
			}
		}

		public void clamp(Positive1.En diameter)
		{
			while (bound.notSpanLessThan(diameter))
			{
				///todo: this can be finetuned by reverse engineering the bound expr of x.
				///
				for (int i = 0; i < 1000; i++)
				{
					_series.moveNext();

				}


			}

		}
	}
}
