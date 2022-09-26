using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction;

namespace nilnul.num.real.stream
{
    public class ArithmeticGeometricMean
    {
		/// <summary>
		/// arithmetic
		/// </summary>
		private double _a;

		public double a
		{
			get { return _a; }
			set { _a = value; }
		}

		private double _g;
		/// <summary>
		/// geometric
		/// </summary>
		public double g
		{
			get { return _g; }
			set { _g = value; }
		}

		public ArithmeticGeometricMean(double x, double y)
		{
			_a = x;
			_g = y;
		}

		/// <summary>
		/// The geometric mean of two positive numbers is never bigger than the arithmetic mean 
		/// </summary>
		/// <param name="n_exclusive"></param>
		/// <returns></returns>
		public IEnumerable<Tuple<double,double>> item(int n_exclusive) {
		
			var current = new Tuple<double,double>(_a, _g);

			for (int i = 0;i<n_exclusive;i++)
			{

				yield return current;
				current=new Tuple<double, double>( (current.Item1+current.Item2)/2, Math.Sqrt(current.Item1 * current.Item2));

			}




			

		}
	}
}
