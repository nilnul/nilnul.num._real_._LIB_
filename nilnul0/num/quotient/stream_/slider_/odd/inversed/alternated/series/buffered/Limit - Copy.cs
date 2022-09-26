using nilnul.num.quotient.bound_;
using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.slider_.odd.inversed.alternated.series
{
	/// <summary>
	/// Tau/8
	/// </summary>
	public class Limit
		: nilnul.obj.Box<nilnul.num.quotient.stream_.slider_.odd.inversed.alternated.Series>
		,
		nilnul.num.RealI
	{
		public Limit() : base(new Series())
		{
			_prev = boxed.current;
			boxed.moveNext();
		}

		nilnul.num.Quotient1 _prev;
		public Closed current => new num.quotient.bound_.Closed(_prev, boxed.current);

		public void squeeze(Positive1 diameter)
		{
			while (current.diameter1.en > diameter)
			{
				_prev = boxed.current;
				boxed.moveNext();
			}
			//throw new NotImplementedException();
		}
	}
}
