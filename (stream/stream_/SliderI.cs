using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_
{
	public interface SliderI: nilnul.obj.stream_.SliderI<nilnul.num.RealI>
		,real.StreamI
	{
	}

	public abstract class SliderA :
		nilnul.obj.stream_.SliderA< nilnul.num.RealI>
		,
		SliderI
	{
		

	}
}
