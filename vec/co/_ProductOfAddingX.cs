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
using R1 = nilnul.num.RealI_onQuotient;


namespace nilnul.num.real.vec.co
{
	/// <summary>
	/// <see cref="real.vec.bi_._AddX"/>, then <see cref="num.real.str."/>
	/// </summary>
	/// <remarks>
	/// vs: <see cref="co.ISumOfMultiplication"/>
	/// </remarks>
	/// alias:
	///		poa
	static public class _ProductOfAddingX
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public int _ProductOfAdd_1equisize(
			this IEnumerable<int> a, IEnumerable<int> b
		) {
			return  a.Zip(b, (x, y) => 
				x+y
			
			).Aggregate(
				1, (a,c) => a*c
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		/// maybe this shall be moved into <see cref="nilnul.num.quotient"/>

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public Q4 _ProductOfAdd_1equisize(this IEnumerable<Q4> a, IEnumerable<Q4> b) {
			return 
				a.Zip(b, (x, y) => 
					
						x + y
					
				).Aggregate(
					(Q4)1, (a,c) => a*c

				)
			;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public float _ProductOfAdd_1equisize(IEnumerable<float> x, IEnumerable<float> y) {

			return
				x.Zip(y, (a, b) => a + b).Aggregate(
					(float)1, (a, c) => a * c

				)
			;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public float _ProductOfAdd_1equisize(float[] x, float[] y) {
			return _ProductOfAdd_1equisize(
				(IEnumerable<float>)x
				,
				(IEnumerable<float>)y

			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _ProductOfAdd_1equisize(
			this IEnumerable<double> x, IEnumerable<double> y
		) {
			return x.Zip(y, (a, b) => a + b).Aggregate(
					1d, (a, c) => a * c

				);
		}
	

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _ProductOfAdd_1equisize((double x,double x1) a, (double y, double y1) b) {
			return _ProductOfAdd_1equisize(
				nilnul.obj.vec.to_.ToStrX.ToStr5(a)
				,
				nilnul.obj.vec.to_.ToStrX.ToStr5(b)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _ProductOfAdd_1equisize((double x,double x1,double x2) a, (double y, double y1, double y2) b) {
			return _ProductOfAdd_1equisize(
				nilnul.obj.vec.to_.ToStrX.ToStr5(a)
				,
				nilnul.obj.vec.to_.ToStrX.ToStr5(b)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _ProductOfAdd_1equisize((double x,double x1,double x2,double x3) a, (double y, double y1, double y2,double y3) b) {
			return _ProductOfAdd_1equisize(
				nilnul.obj.vec.to_.ToStrX.ToStr5(a)
				,
				nilnul.obj.vec.to_.ToStrX.ToStr5(b)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _ProductOfAdd_1equisize((double x,double x1,double x2,double x3,double x4) a, (double y, double y1, double y2,double y3,double y4) b) {
			return _ProductOfAdd_1equisize(
				nilnul.obj.vec.to_.ToStrX.ToStr5(a)
				,
				nilnul.obj.vec.to_.ToStrX.ToStr5(b)
			);
		}
	}
}