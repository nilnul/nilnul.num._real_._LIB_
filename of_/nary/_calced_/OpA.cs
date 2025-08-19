using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.nary._calced_
{
	public abstract class OpA
	{
		private nilnul.num.real.op_.NaryI _op;

		public nilnul.num.real.op_.NaryI op
		{
			get { return _op; }
			set { _op = value; }
		}

		public OpA(nilnul.num.real.op_.NaryI op)
		{
			this._op = op;
		}

	}
}
