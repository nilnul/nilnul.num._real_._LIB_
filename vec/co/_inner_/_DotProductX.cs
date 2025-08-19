using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;


namespace nilnul.num.real.vec.co
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// <see cref="vec.IVariance"/> for a vec dotProduct itself;
	/// </remarks>
	/// alias:
	///		dot product
	///
	[Obsolete(nameof(ISumOfMultiplication) + " is preferred as the name in that 'dot' is a common word to mean something different;")]
	static public class _DotProductX
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double DotProduct(
			(double a,double b) x
			,
			(double a,double b) y
		) {
			return x.a*y.a + x.b*y.b ;
		}
	

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double DotProduct(
			(double a,double b,double c) x
			,
			(double a,double b,double c) y
		) {
			return x.a*y.a + x.b*y.b +x.c*y.c;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double DotProduct(
			(double a,double b,double c, double d) x
			,
			(double a,double b,double c ,double d) y
		) {
			return x.a*y.a + x.b*y.b +x.c*y.c + x.d*y.d;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double DotProduct(
			(double a,double b,double c, double d, double e) x
			,
			(double a,double b,double c ,double d, double e) y
		) {
			return x.a*y.a + x.b*y.b +x.c*y.c + x.d*y.d + x.e*y.e;
		}


	}
}