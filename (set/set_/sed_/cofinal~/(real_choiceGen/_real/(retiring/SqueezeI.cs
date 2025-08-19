using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real
{
	/// <summary>
	/// squeeze from an approach to appraoch to a limit.
	/// </summary>
	public interface SqueezeI
	{
		nilnul.num.quotient.ext.border.duo.be.Bound.Asserted bound { get; }
		void squeeze(nilnul.num.quotient.be.Positive.Asserted diameter);
	}
}
