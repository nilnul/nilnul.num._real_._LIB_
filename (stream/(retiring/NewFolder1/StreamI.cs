using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.RealI2;
using Rx = nilnul.num.real.all.RealX;

namespace nilnul.num.real
{
	public interface StreamI1
		: nilnul._stream.NextI<R>
	{

	}

	public interface StreamOfRxI
		: nilnul._stream.NextI<Rx>
	{

	}

}
