using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real;

namespace  nilnul.num.real_
{

	static public class _TauX
	{
		public const double DOUBLE = 2 * Math.PI;
	}
	/// <summary>
	/// 2Pi
	/// </summary>
	public class Tau : FroApproach
	{
		public Tau( ) : base(new _real.approach_.tau_.Tau_a_())
		{
		}
	}
}
