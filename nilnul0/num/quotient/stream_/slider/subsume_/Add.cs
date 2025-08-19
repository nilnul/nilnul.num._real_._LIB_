using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q3 = nilnul.num.quotient_.DenomNonnil;

namespace nilnul.num.quotient.stream_.slider.subsume_
{

	public class Add< TSlider>
		:
		nilnul.obj.stream_.SliderA<Q3>
		,
		nilnul.obj.stream_.SliderI<Q3>
		where TSlider : nilnul.obj.stream_.SliderI<Q3>

	{
		protected TSlider _slider;
		public Q3 _sum;

		/// <summary>
		/// the initial is the head of the underlying slider;
		/// </summary>
		public override Q3 current => _sum;
		public Add(TSlider slider)
		{
			_slider = slider;
			_sum = slider.current;
		}

		public override void moveNext()
		{

			_slider.moveNext();
			_sum += _slider.current;
		}
	}
}
