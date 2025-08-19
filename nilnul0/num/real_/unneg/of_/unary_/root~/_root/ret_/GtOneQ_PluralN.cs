using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.num.natural.Natural_bigInteger;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num.real.op;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num._real.approach.duo.op_._root.ret_
{


	public class GtOneQ_PluralN
		: 
		ApproachI1
	{
		private nilnul.num.quotient.be_.GtOne.En _radicand;

		public nilnul.num.quotient.be_.GtOne.En radicand
		{
			get { return _radicand; }
			set { _radicand = value; }
		}

		private nilnul._num.bigint.be_.Plural.En _degree;

		public nilnul._num.bigint.be_.Plural.En degree
		{
			get { return _degree; }
			set { _degree = value; }
		}



		public GtOneQ_PluralN(
			nilnul.num.quotient.be_.GtOne.En base_,
			nilnul._num.bigint.be_.Plural.En degree
			
			)

		{
			this._radicand = base_;
			this._degree = degree;

			_bound = nilnul.num.quotient.border.duo.be_.Nonempty.En.CreateOpen(
				1, 
				(_radicand)	
			);

		}

		


		


		

		private Nonempty.En _bound;

		


		public Nonempty.En bound
		{
			get
			{
				return _bound;
			//	throw new NotImplementedException();
			}
		}

		

		public void clamp(Positive1.En diameter)
		{


			while (

				bound.notSpanLessThan(diameter)

				//_accuracy.isNotSubSetOf(accuracy)

				)
			{

				var middle = bound.midPoint;// _rationalCompute();

				var powered = nilnul.num.quotient.duo.op_.Pow.Eval(middle, degree);

				var t = num.quotient.Comparer1.Singleton.Compare(powered, _radicand);



				if (t == 0)
				{
					_bound = nilnul.num.quotient.border.duo.be_.Nonempty.En.CreateSingleton(middle);



				}
				else if (t > 0)
				{
					_bound = nilnul.num.quotient.border.duo.be_.Nonempty.En.CreateOpen(
						_bound.lower.mark
						,
						middle

					);

				}
				else
				{
					_bound = nilnul.num.quotient.border.duo.be_.Nonempty.En.CreateOpen(
						middle
						,
						_bound.upper.mark
					);
				}

			}

			//throw new NotImplementedException();
		}
	}
}
