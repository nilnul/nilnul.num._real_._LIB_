using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.limit.sow;
using R = nilnul.num.RealI;
using N = nilnul._num.bigint.op.Abs.Ed;

namespace nilnul.num.real.op.sqrt.call
{
	public class OfN : R
	{
		private N _arg;

		public N arg
		{
			get { return _arg; }
			set { _arg = value; }
		}


		public ConfluentI confluent
		{
			get
			{

				throw new NotImplementedException();
			}
		}
	}
}
