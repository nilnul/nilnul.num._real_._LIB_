using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.Num1;
using R = nilnul.num.RealI_onQuotient;
using Q1 = nilnul.num.quotient_.DenomNonnil;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using q = nilnul.num.quotient;
using nilnul.obj.stream_._slider._skid_;
using nilnul.num.quotient_.denomNonnil;
using nilnul.num.quotient.co.diameter;
using nilnul.num.quotient.co;


namespace nilnul.num.real_.nonneg.op_._sqrt.ret_.ofQuotient_
{

	public class GtOne
		: 
		RealI_onQuotient
	{
		private nilnul.num.quotient.be_.gtOne.vow.Ee_forDenomNonnil _radicand;

		public nilnul.num.quotient.be_.gtOne.vow.Ee_forDenomNonnil radicand
		{
			get { return _radicand; }
			set { _radicand = value; }
		}




		public GtOne(
			nilnul.num.quotient.be_.gtOne.vow.Ee_forDenomNonnil base_
			
			)

		{
			this._radicand = base_;

			_bound =new (
				1,
				(
				_radicand.eeByRef
				)
			);

		}

		public GtOne(num.quotient_.DenomNonnil arg) : this(new q.be_.gtOne.vow.Ee_forDenomNonnil(arg))
		{
		}

		public GtOne(num.quotient_.DenomNonnilI arg) : this(arg.ToImpl())
		{
		}


		private (Q1 begin, Q1 end) _bound;

		public (Q1 begin, Q1 end) current
		{
			get
			{
				return _bound;
			//	throw new NotImplementedException();
			}
		}


		public void cinch(num.quotient_.denomNonnil_.Positive diameter)
		{


			while (

				current.DiameterGt(diameter)

				//_accuracy.isNotSubSetOf(accuracy)

				)
			{

				var middle = current.Mid();// _rationalCompute();

				//var powered = nilnul.num.quotient.op_._SquareX.Square(middle);

				var t = num.quotient_.denomNonnil.Comp.Singleton.Compare(
					nilnul.num.quotient.op_._SquareX.Square(middle)
					,
					
					_radicand.eeByRef
				);



				if (t == 0)
				{
					_bound = num.quotient.co_._ReflexiveX.ToCo(middle);



				}
				else if (t > 0)
				{
					_bound = (
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
