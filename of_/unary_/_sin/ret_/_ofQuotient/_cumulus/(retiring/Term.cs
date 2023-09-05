using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num._real.approach.op_.uni_._sin.ret_.of_._quotient._series
{
	/// <summary>
	/// the terms for the series
	/// </summary>
	public class Term
		: nilnul.num.quotient.SliderI
	{

		public Term(
			nilnul.num._quotient.fraction.op.Simplify.Ed1 x
		)
		{

			_slider = new nilnul.num.quotient.slider.op_.uni_._alter.Ret(
					nilnul.num.quotient.slider.op_.bi_.Div.Lazy.eval(
						new nilnul.num.quotient.slider_.geometric_.PolyOdd(x)
						,
						new nilnul.num.quotient.slider_.fro_.Natural(new nilnul.num.slider_.OddFactorial())
					)
			);
		}

		private nilnul.num.quotient.SliderI _slider;

		public nilnul.num.quotient.SliderI slider
		{
			get { return _slider; }
			//set { _slider = value; }
		}


		public Simplify.Ed1 current
		{
			get
			{
				return _slider.current;
				//throw new NotImplementedException();
			}
		}

		public void moveNext()
		{
			_slider.moveNext();

			//throw new NotImplementedException();
		}
	}
}
