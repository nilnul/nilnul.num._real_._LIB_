using System.Runtime.CompilerServices;

namespace nilnul.num.real.bi_
{
	/// <summary>
	/// take the averge of two numbers.
	/// </summary>
	/// alias;
	///		avg
	///		mid
	///		mean
	///			,for more
	///		expectation
	static public class _MidX
	{
		/// <summary>
		/// <see cref=""/>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>
		///
		/// </returns>
		///

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Mid(double a, double b) {
			return  (a + b)/2;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Mid(this (double a, double b) x) {
			return  Mid(x.a,x.b);
		}

	}


}
