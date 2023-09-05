using nilnul.num.real;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Plural = nilnul.num.natural.be.Plural.Expr__bigInt;
using Plural1 = nilnul._num.bigint.be_.Plural.En;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num._real.approach.op_._root.ret_
{


	public class PluralPlural
		:

		//nilnul.obj.op.binary.expr.ArgsA<nilnul.num.natural.Natural_bigInteger,nilnul.num.natural.be.Plural.Expr__bigInt>
		//,
		ApproachI1
	{


		private Plural1 _radicand;

		public Plural1 radicand
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



		public PluralPlural(Plural1 radicand, Plural1 degree)

		{
			this._radicand = radicand;
			this._degree = degree;
			_bound = nilnul.num.quotient.border.duo.be_.Nonempty.En.CreateOpen(1, radicand);

			


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

				var t = num.quotient.Comparer1.Singleton.Compare(powered, _radicand.val);



				if (t == 0)
				{
					_bound = nilnul.num.quotient.border.duo.be_.Nonempty.En.CreateSingleton(middle);

					

				}else if (t > 0)
				{
					_bound = nilnul.num.quotient.border.duo.be_.Nonempty.En.CreateOpen(
						_bound.lower.mark
						,
						middle
						
					);

				}
				_bound=nilnul.num.quotient.border.duo.be_.Nonempty.En.CreateOpen(
					middle
					,
					_bound.upper.mark
				);

			}
			//return;
			//throw new NotImplementedException();
		}

		



		private Nonempty.En _bound;

		public Nonempty.En bound
		{
			get
			{
				return _bound;

				throw new NotImplementedException();
			}
		}
	}




}
