using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.str.op_
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="real.vec.op_._ScaleX"/>
	static public class _ShrinkX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _Shrink_1unnil(this IEnumerable<double> a, double scale) {
			return  a.Select(x=> x/scale);
		}

	}
}
