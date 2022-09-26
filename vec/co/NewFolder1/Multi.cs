using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.num.real.str.duo.sameLen
{
	//[Obsolete()]
	[Obsolete(nameof(vec.co._InnerProductX))]
	public class Multi
	{
		static public float _Eval(IEnumerable<float> x, IEnumerable<float> y) {
			return x.Zip(y, (a, b) => a * b).Sum();
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
