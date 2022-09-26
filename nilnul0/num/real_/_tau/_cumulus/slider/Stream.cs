using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num._real.approach_.tau_._a.slider
{
	public class Stream
		: nilnul.num.quotient.StreamI3
	{
		
		tau_._a.Slider _slider;
		internal tau_._a.Slider slider
		{
			get
			{
				return _slider;
			}
		}

		public Q1 coefficientComing{
			get {
				return _slider.coefficent;
			}
		}

		nilnul.num.quotient.slider.Stream _stream;

		public Stream()
		{
			_slider = new Slider();
			_stream = new quotient.slider.Stream(_slider);
		}

		public Q1 next()
		{
			return _stream.next();
		
		}
	}
}
