using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace nilnul.num.real.str.scala_
{
	static public class _PotenceX
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Potence(this IEnumerable<double> a)
		{
			return a.Select(x => x * x).Sum();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4 Potence(this IEnumerable<Q4> a)
		{
			return nilnul.num.quotient.str._SumX.Sum( a.Select(x => x * x) );
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public int Potence(this IEnumerable<int> a)
		{
			return  a.Select(x => x * x).Sum();
		}

	}

}
