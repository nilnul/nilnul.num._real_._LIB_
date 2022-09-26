using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.stream_._cauchy;
using C = nilnul.num._real.CauchyI2;
using A = nilnul.num._real._cauchy.ApproachI;
using nilnul.obj._stream_;

namespace nilnul.num._real.cauchy_
{
	public class Wallis :
		nilnul.num.quotient.stream_.Slider
		//,
		//nilnul.num.quotient.slider.op_.binary_._multi.Ret1
		,
		C
	{
		static public nilnul.num.quotient.slider.op_.binary_._alt.Ret GenSlider() =>
				 new nilnul.num.quotient.slider.op_.binary_._alt.Ret(
		new _wallis_.EvenTerms(), new _wallis_.OddTerms()
		);


		static public nilnul.num.quotient.slider_.cumulative_.Product GenProduct()
		=> new nilnul.num.quotient.slider_.cumulative_.Product(GenSlider());

		Quotient1 NextI<Quotient1>.next()
		{
			return new Quotient1(next());
			throw new NotImplementedException();
		}

		public A approach => new _wallis.Approach();

		public Wallis() : base(
			GenProduct()
		)
		{

		}

	}


}
