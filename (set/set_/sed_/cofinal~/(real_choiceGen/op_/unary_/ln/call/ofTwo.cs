using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using r=nilnul.num.real;
using q = nilnul.num.quotient;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.real.op.ln.call
{
	public class _OfTwo {
		static public double Approximate = 0.69314718;


	}


	public class OfTwo_alternateInverse

		: _real.RealI
	{


		q.stream._seriesS.AlternateInverse _alternateInverse = new q.stream._seriesS.AlternateInverse();


		public nilnul.num.quotient.ext.border.duo.be.Range.Asserted range
		{
			get
			{

				throw new NotImplementedException();
			}
		}

		public void converge(Positive.Asserted diameter)
		{
			throw new NotImplementedException();
		}
	}
}
