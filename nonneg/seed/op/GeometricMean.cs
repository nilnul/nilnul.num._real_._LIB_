using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.nonneg.seed.op
{
	/// <summary>
	/// note: 1,1,2,... so this is better treated as a str rather than a set.
	/// </summary>
	public class GeometricMean
	{
		static public double _Eval(params double[] _seed_allNonneg) {

			return nilnul.num.real.op.Root1._Eval(str.op.Product.Eval(_seed_allNonneg), _seed_allNonneg.Length); ;

		}

		static public double _Eval(IEnumerable<double> _seed_allNonneg) {

			return nilnul.num.real.op.Root1._Eval(str.op.Product.Eval(_seed_allNonneg), _seed_allNonneg.Count()); ;

		}

	}
}
