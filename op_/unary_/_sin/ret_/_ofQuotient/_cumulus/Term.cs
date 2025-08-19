using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q0 = nilnul.num.Quotient1;

namespace nilnul.num.real.op_.unary_._sin.ret_._ofQuotient._cumulus
{
	/// <summary>
	/// the terms for the series
	/// </summary>
	public class Term
		:
		nilnul.num.quotient.stream_.SliderA1 //.SliderI1
	{

		public Term(
			nilnul.num.Quotient1 x
		)
		{
			/// x^1 /1! -x^3/3! + 

			_slider = new nilnul.num.quotient.stream_.slider.op_.unary_._alter.Ret(
					nilnul.num.quotient.stream_.slider.op_.binary_.Div.Lazy.op(
						new nilnul.num.quotient.stream_.slider_.geometric_.PolyOdd(x)
						,
						new nilnul.num.quotient.stream_.slider_.OfNums(new nilnul.num.stream_.slider_.OddFactorial1())
				)
			);
		}

		private nilnul.num.quotient.stream_.SliderI1 _slider;

		public  nilnul.num.quotient.stream_.SliderI1 slider
		{
			get { return _slider; }
			//set { _slider = value; }
		}


		public override Q0 current
		{
			get
			{
				return _slider.current;
				//throw new NotImplementedException();
			}
		}

		public override void moveNext()
		{
			_slider.moveNext();

			//throw new NotImplementedException();
		}
	}
}
