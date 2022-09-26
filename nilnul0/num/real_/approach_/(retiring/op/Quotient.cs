using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real._approach.members;
using nilnul.num.quotient.be;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient.ext.border.duo.be;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num._real.approach_
{
	[Obsolete(nameof(nilnul.num._real._cauchy.ApproachI))]
	public class Quotient
		: ApproachI1
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

		public Quotient(int num, int den):this(new Q(num,den))
		{

		}

		public Quotient():this(0)
		{

		}
		public 		quotient.border.duo.be_.Nonempty.En bound
		{
			get
			{
				return num.quotient.border.duo.be_.Nonempty.En.CreateSingleton(_quotient);
				throw new NotImplementedException();
			}
		}

		public void clamp(quotient.be_.Positive1.En diameter)
		{
			return;
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return _quotient.ToString();
		}

		public  static ApproachI1 CreateOne()
		{
			return new Quotient(1);
			throw new NotImplementedException();
		}

		public  static ApproachI1 CreateHalf()
		{
			return new Quotient(1,2);
			//throw new NotImplementedException();
		}

	}
}
