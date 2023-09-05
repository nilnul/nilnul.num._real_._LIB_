using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.rational.be;
using nilnul.num.rational.bound.pair.be;
using nilnul.num.quotient;
using System.Numerics;
using Q = nilnul.num.quotient.Q;
using Interval = nilnul.num.quotient.border.duo.be_.Nonempty.En;
using B = nilnul.num.quotient.border.duo.be_.Nonempty.En;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.real_.unison_
{
	public class EulerConstant :IUnison
	{

		public quotient.Q harmonic = 1;

		public RealI_posConverge2NonEmpty lnN = real.Quotient_posConverge2Bounded.NewZero();


		private BigInteger _n;
		private BigInteger _n_plus_1;

		private BigInteger _2_times__nPlus1;
		private _real.Quotient_posConverge2Bounded _H_n;

		private RealI_posConverge2NonEmpty _H_n__subtract__ln_n;

		public EulerConstant()
		{
			_n = 1;
			_n_plus_1 = 2;
			_2_times__nPlus1 = 2 * _n_plus_1;

			_H_n = 1;

			_H_n__subtract__ln_n = op.Subtract3.Eval(
				_H_n,
				op.Ln.Eval(_n)
			);


		}

		public B interval_quotient
		{
			get
			{
				return quotient.range.duo.op_.Minus.Eval(

					new B(
					_H_n__subtract__ln_n.interval.val.lower.eq,

					
					_H_n__subtract__ln_n.interval.val.lower.pinpoint.toNewVersion()
					
					,

					_H_n__subtract__ln_n.interval.val.upper.eq,
					_H_n__subtract__ln_n.interval.val.upper.pinpoint.toNewVersion()
					)

					,

					new B(
						false
						,
						nilnul.num.quotient.Q.Inverse(2 * _n_plus_1).toNewVersion()
						,
						false
						,
						nilnul.num.quotient.Q.Inverse(2 * _n).toNewVersion()
					)
					)
					;


				throw new NotImplementedException();
			}
		}

		

		public void converge(quotient.be_.Positive1.En diameter)
		{

			while (interval_quotient.notSpanLessThan(diameter))
			{

				_n = _n_plus_1;
				_n_plus_1++;

				_2_times__nPlus1 += 2;

				_H_n += Q.Inverse(_n);

				_H_n__subtract__ln_n = op.Subtract3.Eval(
					_H_n,
					op.Ln.Eval(_n)
				);

				_H_n__subtract__ln_n.converge(
					new Positive.Asserted(
					Q.Inverse(2 * _n_plus_1))

				);




			}
			return;

			throw new NotImplementedException();
		}
	}
}
