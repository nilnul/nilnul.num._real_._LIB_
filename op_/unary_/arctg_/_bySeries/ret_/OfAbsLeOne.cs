using nilnul.num.quotient.bound_;
using nilnul.num.quotient_;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.unary_.arctg_._bySeries.ret_
{
	public class OfAbsLeOne
		: nilnul.obj.Box<nilnul.num.real_.AbsLeOne>
		,
		nilnul.num.RealI
	{
		public OfAbsLeOne(AbsLeOne val) : base(val)
		{
			var lowerOped = num.real.convert_.arctg_._OfQuotientX._ofAbsLeOne(boxed.current.lower);
			var upperOped = num.real.convert_.arctg_._OfQuotientX._ofAbsLeOne(boxed.current.upper);

			_current = new Closed(
				lowerOped.current.lower
				,
				upperOped.current.upper
			);

		}

		public OfAbsLeOne(RealI par) : this(new AbsLeOne(par))
		{
		}

		private num.quotient.bound_.Closed _current;

		public Closed current => _current;

		public void squeeze(Positive1 diameter)
		{

			/*
			var xShallSqueezeTo = diameter / (1 / (1
				+ nilnul.num.quotient.op_.unary_._SquareX.Square(
					nilnul.num.quotient.op_.binary_._MinX.Min(
						nilnul.num.quotient.op_.unary_._AbsX.Op(
							boxed.current.lower
						)
						,
						nilnul.num.quotient.op_.unary_._AbsX.Op(
							boxed.current.upper
						)

					)
				)
			));
			*/

			var par2squeezeTo = new Positive1(diameter * (1
					+ nilnul.num.quotient.op_.unary_._SquareX.Square(
						nilnul.num.quotient.op_.binary_._MinX.Min(
							nilnul.num.quotient.op_.unary_._AbsX.Op(
								boxed.current.lower
							)
							,
							nilnul.num.quotient.op_.unary_._AbsX.Op(
								boxed.current.upper
							)
						)
					)
				) / 3
			);

			this.boxed.squeeze(
					par2squeezeTo
			);

			var lowerOped = real.convert_.arctg_._OfQuotientX._ofAbsLeOne(boxed.current.lower);
			var upperOped = real.convert_.arctg_._OfQuotientX._ofAbsLeOne(boxed.current.upper);

			lowerOped.squeeze(
				par2squeezeTo
			);

			upperOped.squeeze(
				par2squeezeTo
			);

			_current = new Closed(
				lowerOped.current.lower
				,
				upperOped.current.upper
			);




		}
	}
}
