using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_
{

	static public class _FloorX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Obsolete(nameof(Math.Floor))]
		static public double Floor(double x) {
			return Math.Floor(x);
		}
	}


}
