
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num.real.be_.negative.vow;

namespace nilnul.num.real_
{
	public interface NegDblI
	{

		nilnul.num.real.be_.neg.vow.Ee4dbl ee{ get; }

	}

	public class NegDbl :
		num.real.be_.neg.vow.Ee4dbl
		, NegDblI
		,
		_real_.DblI
	{


		public nilnul.num.real.be_.neg.vow.Ee4dbl ee => this;

		public double Dbl => this.ee.ee;

		public NegDbl(double val) : base(val)
		{

		}
	}
}
