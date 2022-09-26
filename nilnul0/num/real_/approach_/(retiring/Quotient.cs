using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num._real.squeeze
{
	public class Quotient
		: num._real.SqueezeI
	{
		private Q _quotient;

		public Q quotient
		{
			get { return _quotient; }
			set { _quotient = value; }
		}

		public Quotient(Q q)
		{
			_quotient = q;

		}
		public nilnul.num.quotient.ext.border.duo.be.Bound.Asserted bound
		{
			get
			{
				return nilnul.num.quotient.ext.border.duo.be.Bound.Asserted.CreateSingleton(_quotient);
				throw new NotImplementedException();
			}
		}

		public void squeeze(Positive.Asserted diameter)
		{
			return;
			throw new NotImplementedException();
		}
	}
}
