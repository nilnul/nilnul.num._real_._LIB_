using nilnul.num.quotient.stream_.fractile.convergent;
using nilnul.num.quotient.stream_.fractile.convergent.streamy_;
using nilnul.num.quotient_.denomNonnil.bound_;
using nilnul.num.real_.fractile_.periodic_._golden;
using nilnul.obj;
using nilnul.obj._stream_._next;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.fractile_.periodic_.golden.convergent.stream_.slider
{
	public class Cauchy
		:
		nilnul.obj.Box_ofIn<
			nilnul.num.real_.fractile_.periodic_.golden.convergent.stream_.Slider
		>
		,
		nilnul.num.quotient_.denomNonnil.bound_.closed.stream_._slider.skid_.nested_.CauchyI
	{
		 Cauchy(in Slider val) : base(val)
		{
		}

		 Cauchy(Slider x) : base(x)
		{
		}

		public Cauchy() : this(new nilnul.num.real_.fractile_.periodic_.golden.convergent.stream_.Slider() )
		{
		}

	

		public Closed _current;

		public Closed current => new Closed(
			boxed.
		);

		public void clamp(num.quotient_.denomNonnil_.Positive diameter)
		{
			throw new NotImplementedException();
		}

		public void moveNext()
		{

			throw new NotImplementedException();
		}
	}


}
