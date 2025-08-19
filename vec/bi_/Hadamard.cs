using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.of_.binary_
{
	/// <summary>
	/// used in 3d geometry shader programming;
	/// </summary>
	/// <remarks>
	/// denoted by a small circle.
	/// </remarks>
	internal class _HadamardX
	{
		
		static public IEnumerable<double> _Hadamard_01equisize(IEnumerable<double> a, IEnumerable<double> b) {
			return a.Zip(b, (x, y) => x * y);
		}
	}
}
