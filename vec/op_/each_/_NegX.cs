using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.op_
{
    static public class _NegateX
    {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]

		static public (double a, double b) Negate(in (double a, double b) vec) {
			return (-vec.a, -vec.b);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (double a, double b, double c) Negate(in (double a, double b, double c) vec) {
			return (-vec.a, -vec.b, -vec.c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (double a, double b, double c, double d) Negate(in (double a, double b, double c, double d) vec) {
			return (-vec.a, -vec.b, -vec.c, -vec.d);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public (double a, double b, double c, double d, double e) Negate(in (double a, double b, double c, double d, double e) vec) {
			return (-vec.a, -vec.b, -vec.c, -vec.d, -vec.e);
		}


    }
}
