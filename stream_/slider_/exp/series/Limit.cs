using nilnul.num.quotient.bound_;
using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider_.exp.series
{
	public class Limit
		: nilnul.obj.Box<exp.Series>
		,
		RealI
	{
		public Limit(RealI val) : base(new Series(val))
		{


		}

		public Closed current => throw new NotImplementedException();

		public void squeeze(Positive1 diameter)
		{


			throw new NotImplementedException();
		}
	}
}
