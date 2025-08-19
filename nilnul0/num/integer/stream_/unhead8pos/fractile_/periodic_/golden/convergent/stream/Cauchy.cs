using nilnul.num.quotient.stream_.fractile.convergent;
using nilnul.num.quotient_.denomNonnil.bound_;
using nilnul.num.real_._fractile.fractile_.periodic_._golden;
using nilnul.obj;
using nilnul.obj._stream_._next;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_._fractile.fractile_.periodic_.golden.convergent.stream
{
	public class Cauchy
		:
		nilnul.obj.Box_ofIn<
			nilnul.num.quotient.stream_.fractile.convergent._Stream
		>
		,
		nilnul.num.quotient_.denomNonnil.bound_.closed.stream_._slider.skid_.nested_.CauchyI
	{

		 Cauchy(in _Stream val) : base(val)
		{
		}

		 Cauchy(_Stream x) : base(x)
		{
		}

		 Cauchy(Adders adders):this(new _Stream(adders))
		{
		}
		public Cauchy() : this(new _golden.Adders())
		{
		}


		public Closed _current;

		public Closed current => _current;

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
