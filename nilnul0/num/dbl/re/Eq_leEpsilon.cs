using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.doubl
{
	public partial class Eq_leEpsilon
		:IEqualityComparer<double>
	{
		static public bool NoMoreThan1_1000000_(double x , double y) {
			return Math.Abs(x - y) <= 0.000001;
		}



		private double _epsilon;

		public double epsilon
		{
			get { return _epsilon; }
			set { _epsilon = value; }
		}

		public Eq_leEpsilon(double espsilon)
		{
			_epsilon = epsilon;

		}

		public bool Equals(double x, double y)
		{
			return Math.Abs(x - y) < _epsilon;

			throw new NotImplementedException();
		}

		public int GetHashCode(double obj)
		{
			return obj.GetHashCode();
			throw new NotImplementedException();
		}

		static public Eq_leEpsilon Default = new Eq_leEpsilon(double.Epsilon);
	}
}
