using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.stream_.slider_.poly.series_.convergent_._sin
{
	public class Slider : 
		nilnul.num.real.stream_.slider_.Alter
		
		,
		nilnul.num.real.stream_.SliderI
	{

		public Slider(R x) : base(

			 nilnul.num.real.stream_.slider.op_.binary_._MultiX.Op(
				new nilnul.num.real.stream_.slider_.geometric_.PolyOdd(x)
				,
				 //nilnul.num.quotient.slider.op_.unary_.Alter.Singleton.op(
					nilnul.num.quotient.stream_.slider.op_.unary_.Inv.Singleton.op(
						new nilnul.num.stream_.slider_.OddFactorial1()
					)
				//)
			)
		)
		{
		}

		
	}
}
