using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.scala_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		product
	///		pi, reserved for discrete case which might be infinite
    static public class _ProductX
    {



		/// <summary>
		/// 
		/// </summary>
		/// <param name="doubles"></param>
		/// <returns></returns>

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Product(IEnumerable<double> doubles) {

			return num.real.bi_.mul.cumulator._CumulateX.Cumulate(doubles);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Product(params double[] doubles) {
			return Product( (IEnumerable<double>) doubles );
		}

		/// <summary>
		/// short cut for <see cref="Product(double[])"/> to optimize
		/// </summary>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Product() {
			return 1;
		}

		/// <summary>
		/// </summary>
		/// <param name="x"></param>
		/// <returns>
		/// 0 when x is 0. hence here it's smaller than <see cref="Product()"/>
		/// </returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Product(double x) {
			return x;
		}

    }
}
