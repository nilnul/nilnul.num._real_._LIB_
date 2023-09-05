using nilnul.num.quotient.bound_;
using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.slider_.odd.inversed.alternated.series.buffered
{
	/// <summary>
	/// 1-1/3 + 1/5 -1/7 +...  = Tau/8.
	/// This is very very slow
	/// </summary>
	/// <remarks>
	/// 1-1/3 + 1/5 +...
	/// =
	/// from 0 to 1, integrate of 1 - x^2 + x^4
	/// =
	/// from 0 to 1, integrate of 1/(1+x^2)
	///
	/// but antiderivative of 1/(1+x^2) is arctan(x)
	/// </remarks>
	public class Limit
		: nilnul.obj.Box<nilnul.num.quotient.stream_.slider_.odd.inversed.alternated.series.BufferedTwo>
		,
		nilnul.num.RealI
	{
		public Limit() : base(new BufferedTwo())
		{
			//_prev = boxed.current;
			//boxed.moveNext();
		}

		//nilnul.num.Quotient1 _prev;
		public Closed current =>  num.quotient.bound_.Closed.Create_orderIfNecessary( boxed.current, boxed.buffer.boxed[1]);

		public void squeeze(Positive1 diameter)
		{
			while (current.diameter1.en > diameter)
			{
				
				boxed.move();
			}
			//throw new NotImplementedException();
		}
	}
}
