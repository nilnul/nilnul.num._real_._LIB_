using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.fn_
{
	abstract class Confine8dblA
	: Confined8dbl
		,
		nilnul.num.real.Op8dblI
	{
		private Collection4dblI _confine;

		public Collection4dblI confine
		{
			get { return _confine; }
			set { _confine = value; }
		}

		public double op(in double x)
		{
			if (_confine.has(x) )
			{
				return _op_0confined(x);
			}
			throw new ArgumentOutOfRangeException(nameof(x), x, $"out of scope {_confine}");
		}

		public abstract double _op_0confined(double x);

		

	}


}
