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
	/// Tau/8. This is very very slow
	/// </summary>
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
