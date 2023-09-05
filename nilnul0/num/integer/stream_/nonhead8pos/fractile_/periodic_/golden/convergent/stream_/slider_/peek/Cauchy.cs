using nilnul.num.quotient.bound;
using nilnul.num.integer.stream_.nonhead8pos.fractile.convergent;
using nilnul.num.integer.stream_.nonhead8pos.fractile.convergents_;
using nilnul.num.quotient_.denomNonnil.bound_;
using nilnul.num.integer.stream_.nonhead8pos.fractile_.periodic_._golden;
using nilnul.obj;
using nilnul.obj._stream_._next;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient_;
using nilnul.obj.stream_._slider._skid_;

namespace nilnul.num.integer.stream_.nonhead8pos.fractile_.periodic_.golden.convergent.stream_.slider_.peek
{
	public class Cauchy
		:
		nilnul.obj.Box_ofIn<
			nilnul.num.integer.stream_.nonhead8pos.fractile_.periodic_.golden.convergent.stream_.slider_.Peek
		>
		//,
		//nilnul.num.quotient_.denomNonnil.bound_.closed.stream_._slider.skid_.nested_.CauchyI
		,
		RealI1
	{
		public Cauchy(in Peek val) : base(val)
		{
		}

		public Cauchy(Peek x) : base(x)
		{
		}
		 Cauchy(in Slider val) : this( new Peek())
		{
		}

		 Cauchy(Slider x) : this(in x)
		{
		}

		public Cauchy() : this(new nilnul.num.integer.stream_.nonhead8pos.fractile_.periodic_.golden.convergent.stream_.Slider() )
		{
		}



		public
		(DenomNonnil, DenomNonnil) current =>(boxed.current,boxed.ahead)
			;

		//boxed.current<=boxed.ahead?new Closed(
		//	boxed.current
		//	,
		//	boxed.ahead
		//): new Closed(
		//	boxed.ahead
		//	,
		//	boxed.current
		//);

		public void clamp(num.quotient_.denomNonnil_.Positive diameter)
		{
			while (
				(current.Item1-current.Item2).toAbs()>diameter
			)
			{
				moveNext();
			}
		}

		public void moveNext()
		{
			boxed.moveNext();
		}
	}


}
