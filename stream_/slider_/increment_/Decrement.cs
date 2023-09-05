using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider_.increment_
{
	/// <summary>
	/// minus
	/// </summary>
	public class Decrement : Increment
	{
		public Decrement(RealI head,Real decrement) : base(head, -decrement)
		{
		}

		public Decrement(RealI head,RealI decrement) : this(head, decrement.ToImpl())
		{
		}


	}
}
