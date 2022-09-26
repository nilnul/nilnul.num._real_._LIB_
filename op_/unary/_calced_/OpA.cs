using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.unary._calced_
{
	public abstract class OpA
	{
		private nilnul.num.real.op_.UnaryI _op;

		public nilnul.num.real.op_.UnaryI op
		{
			get { return _op; }
			set { _op = value; }
		}

		public OpA(nilnul.num.real.op_.UnaryI op)
		{
			this._op = op;
		}

	}
}
