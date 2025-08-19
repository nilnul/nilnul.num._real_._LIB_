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
	/// 
	/// </summary>
	/// alias:
	///		dot product
	static public class _InnerProductX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>0 when each vec is 0d;</returns>

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public R _InnerProduct_assumeEquisize(this IEnumerable<R> a, IEnumerable<R> b) {
			return a.Zip(b, (x, y) => 
				nilnul.num.real.op_.binary_.Multi.Singleton.op(
					x , y
				)
			
			).Sum();
		}



		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public int _InnerProduct_assumeEquisize(this IEnumerable<int> a, IEnumerable<int> b) {
			return a.Zip(b, (x, y) => 
				x*y
			
			).Sum();
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public R1 _InnerProduct_assumeEquisize(this IEnumerable<R1> a, IEnumerable<R1> b) {
			return nilnul.num.real.str._ExtensionsX.Sum(
				a.Zip(b, (x, y) => 
					nilnul.num.real.bi_._MultiplyX.Multiply(
						x , y
					)
				)
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
		static public Q4 _InnerProduct_1equisize(this IEnumerable<Q4> a, IEnumerable<Q4> b) {
			return nilnul.num.quotient.str._SumX.Sum(
				a.Zip(b, (x, y) => 
					
						x * y
					
				)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public float _InnerProduct_assumeEquisize(IEnumerable<float> x, IEnumerable<float> y) {
			return x.Zip(y, (a, b) => a * b).Sum();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public float _InnerProduct_assumeEquisize(float[] x, float[] y) {
			return nilnul.num.real.tuple.combine_._MultiX._Eval(x,y).Sum();
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _InnerProduct_1equisize(this IEnumerable<double> x, IEnumerable<double> y) {
			return x.Zip(y, (a, b) => a * b).Sum();
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _InnerProduct_assumeEquisize(this IEnumerable<double> x, IEnumerable<double> y) {
			return _InnerProduct_1equisize(x,y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double InnerProduct((double x,double x1) a, (double y, double y1) b) {
			return _InnerProduct_1equisize(
				nilnul.obj.vec.to_.ToStrX.ToStr5(a)
				,
				nilnul.obj.vec.to_.ToStrX.ToStr5(b)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double InnerProduct((double x,double x1,double x2) a, (double y, double y1, double y2) b) {
			return _InnerProduct_1equisize(
				nilnul.obj.vec.to_.ToStrX.ToStr5(a)
				,
				nilnul.obj.vec.to_.ToStrX.ToStr5(b)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double InnerProduct((double x,double x1,double x2,double x3) a, (double y, double y1, double y2,double y3) b) {
			return _InnerProduct_1equisize(
				nilnul.obj.vec.to_.ToStrX.ToStr5(a)
				,
				nilnul.obj.vec.to_.ToStrX.ToStr5(b)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double InnerProduct((double x,double x1,double x2,double x3,double x4) a, (double y, double y1, double y2,double y3,double y4) b) {
			return _InnerProduct_1equisize(
				nilnul.obj.vec.to_.ToStrX.ToStr5(a)
				,
				nilnul.obj.vec.to_.ToStrX.ToStr5(b)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _OfRow(double[,] x, int row, double[] y) {
			return _InnerProduct_assumeEquisize(
				nilnul.collection.matrix.MatrixX.Row(x, row)
				,
				y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public float _OfRow(float[,] x, int row, float[] y) {
			return _InnerProduct_assumeEquisize(
				nilnul.collection.matrix.MatrixX.Row(x, row)
				,
				y
			);
			
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _OfRowCol(double[,] x, int row, double[,] y, int col) {
			return _InnerProduct_assumeEquisize(
				nilnul.collection.matrix.MatrixX.Row(x, row), nilnul.collection.matrix.MatrixX.Column(y, col)
			);
			
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public float _OfRowCol(float[,] x, int row, float[,] y, int col) {
			return _InnerProduct_assumeEquisize(
				nilnul.collection.matrix.MatrixX.Row(x, row), nilnul.collection.matrix.MatrixX.Column(y, col)
			);
			
		}



	}
}