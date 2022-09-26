using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;


namespace nilnul.num.real.tuple.duo
{
	[Obsolete(nameof(vec.co._InnerProductX))]
	public class _InnerProductX
	{

		static public R _Multi_ofTwoSameLengthStr(IEnumerable<R> a, IEnumerable<R> b) {
			return a.Zip(b, (x, y) => 
				nilnul.num.real.op_.binary_.Multi.Singleton.op(
					x , y
				)
			
			).Sum();
		}
		static public float _Eval(IEnumerable<float> x, IEnumerable<float> y) {
			return x.Zip(y, (a, b) => a * b).Sum();
		}

		static public float _Eval(float[] x, float[] y) {
			return nilnul.num.real.tuple.combine_._MultiX._Eval(x,y).Sum();
		}


		static public double _Eval(IEnumerable<double> x, IEnumerable<double> y) {
			return x.Zip(y, (a, b) => a * b).Sum();
		}

		static public float _Eval(float[,] x, int row, float[,] y, int col) {
			return _Eval(
				nilnul.collection.matrix.MatrixX.Row(x, row), nilnul.collection.matrix.MatrixX.Column(y, col)
			);
			
		}
		static public double _Eval(double[,] x, int row, double[] y) {
			return _Eval(
				nilnul.collection.matrix.MatrixX.Row(x, row)
				,
				y
			);
			
		}

		static public float _Eval(float[,] x, int row, float[] y) {
			return _Eval(
				nilnul.collection.matrix.MatrixX.Row(x, row)
				,
				y
			);
			
		}

		static public double _Eval(double[,] x, int row, double[,] y, int col) {
			return _Eval(
				nilnul.collection.matrix.MatrixX.Row(x, row), nilnul.collection.matrix.MatrixX.Column(y, col)
			);
			
		}
	}
}