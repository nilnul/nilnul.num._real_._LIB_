using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.Num1;
using R = nilnul.num.RealI_onQuotient;
using Q1 = nilnul.num.quotient_.DenomNonnil;

using nilnul.num.quotient.co.diameter;

using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using q = nilnul.num.quotient;
using nilnul.obj.stream_._slider._skid_;
using nilnul.num.quotient_.denomNonnil;
using nilnul.num.quotient.co;

namespace nilnul.num.real_.nonneg.op_._sqrt.ret_.ofQuotient_
{

	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		<see cref="nilnul.num.real.bound_.fuzzy_.IPortion"/>
	public class PositiveLtOne
		: 
		RealI_onQuotient
	{
		private nilnul.num.quotient.be_.positive_.ltOne.vow.Ee _radicand;

		public nilnul.num.quotient.be_.positive_.ltOne.vow.Ee radicand
		{
			get { return _radicand; }
			set { _radicand = value; }
		}



		public PositiveLtOne(
			nilnul.num.quotient.be_.positive_.ltOne.vow.Ee base_
		)

		{
			this._radicand = base_;

			_bound =(
				
				
					_radicand.eeByRef.ToImpl()
				
				,
				1
			);

		}
		public PositiveLtOne(num.quotient_.DenomNonnilI arg):this(new q.be_.positive_.ltOne.vow.Ee(arg))
		{
		}

		public PositiveLtOne(num.quotient_.DenomNonnil arg):this((num.quotient_.DenomNonnilI)arg)
		{
		}

		private (Q4 begin, Q4 end) _bound;

		public (Q4 begin, Q4 end) current 
		{
			get
			{
				return _bound;
			}
		} 

		public void cinch(num.quotient_.denomNonnil_.Positive diameter)
		{
			while (
				current.DiameterGt(diameter)
			)
			{
				var middle = current.Mid();//.midPoint;

				var t = num.quotient_.denomNonnil.Comp.Singleton.Compare(
					nilnul.num.quotient.op_._SquareX.Square(middle)
					,
					_radicand.eeByRef 
				);

				if (t == 0)
				{
					_bound = (middle,middle);
				}
				else if (t > 0)
				{
					_bound =(
						_bound.begin 
						,
						middle

					);

				}
				else
				{
					_bound =(
						middle
						,
						_bound.end
					);
				}

			}

		}
	}
}
