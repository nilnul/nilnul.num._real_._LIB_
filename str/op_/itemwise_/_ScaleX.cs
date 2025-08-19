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
	static public class _ScaleX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> Scale(this IEnumerable<double> a, double scale) {
			return  a.Select(x=> x*scale);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<Q4> Scale(this IEnumerable<Q4> a, Q4 scale) {
			return  a.Select(x=> x*scale);
		}


	}
}
