using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_
{
	public interface Slider4dblI: nilnul.obj.stream_.SliderI<double>
		,real.Stream4dblI
	{
	}

	public abstract class Slider4dblA :
		nilnul.obj.stream_.SliderA< double>
		,
		Slider4dblI
	{
		

	}
}
