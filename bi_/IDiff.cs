using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bi_
{
	/// as a+b =c, and the plus is commutative, hence diff can mean c-a, or c-b.
	/// <seealso cref="bi_.div_"/>
	/// <summary>
	/// like git dif, either one can be the base. the base is also called remnant;
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// alias:
	///		dif
	///			, analog
	///		diff
	///			,which can be used for <see cref="obj.re_.IDif"/>
	///		differentiate
	///		delta
	///		nabla, for gradient, the difference of vector;
	public interface IDifference:real.IBi
	{
	}

}
