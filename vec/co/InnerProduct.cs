using System;
using System.Collections.Generic;
using System.Linq;
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
	/// alias:
	///		dot product
	static public class _InnerProductX
	{

		static public R _InnerProduct_assumeEquisize(this IEnumerable<R> a, IEnumerable<R> b) {
			return a.Zip(b, (x, y) => 
				nilnul.num.real.op_.binary_.Multi.Singleton.op(
					x , y
				)
			
			).Sum();
		}
		static public float _InnerProduct_assumeEquisize(IEnumerable<float> x, IEnumerable<float> y) {
			return x.Zip(y, (a, b) => a * b).Sum();
		}

		static public float _InnerProduct_assumeEquisize(float[] x, float[] y) {
			return nilnul.num.real.tuple.combine_._MultiX._Eval(x,y).Sum();
		}


		static public double _InnerProduct_assumeEquisize(this IEnumerable<double> x, IEnumerable<double> y) {
			return x.Zip(y, (a, b) => a * b).Sum();
		}

		static public double _OfRow(double[,] x, int row, double[] y) {
			return _InnerProduct_assumeEquisize(
				nilnul.collection.matrix.MatrixX.Row(x, row)
				,
				y
			);
			
		}

		static public float _OfRow(float[,] x, int row, float[] y) {
			return _InnerProduct_assumeEquisize(
				nilnul.collection.matrix.MatrixX.Row(x, row)
				,
				y
			);
			
		}

		static public double _OfRowCol(double[,] x, int row, double[,] y, int col) {
			return _InnerProduct_assumeEquisize(
				nilnul.collection.matrix.MatrixX.Row(x, row), nilnul.collection.matrix.MatrixX.Column(y, col)
			);
			
		}
		static public float _OfRowCol(float[,] x, int row, float[,] y, int col) {
			return _InnerProduct_assumeEquisize(
				nilnul.collection.matrix.MatrixX.Row(x, row), nilnul.collection.matrix.MatrixX.Column(y, col)
			);
			
		}

	}
}