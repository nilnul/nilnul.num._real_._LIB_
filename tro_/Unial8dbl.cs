using nilnul.num.real.tro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.tro_
{

		/// <summary>
		/// maintain a mechanism to accept what is unial: by certain operations.
		/// </summary>
		public class Unial8dbl:IUnial
		{
			private (double i, double j, double k) _vec;

			public (double i, double j, double k) vec
			{
				get { return _vec; }
				///set { _vec = value; }
			}

			/// <summary>
			/// unverfied
			/// </summary>
			/// <param name="vec"></param>
			private Unial8dbl((double i, double j, double k) vec)
			{
				_vec = vec;
			}

		/// <summary>
		/// here we compare the variance, which is x^2, and smooth,  not the departure which is |x| that is cusp,  with 1.
		/// using variance is also efficient
		/// </summary>
		/// <remarks>
		/// use the variance, not the component (which is <see cref="nilnul.obj.vec.IComponent"/>, a projection function), or the distance
		/// </remarks>
		/// <param name="vec"></param>
		/// <param name="ratio"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
			static public Unial8dbl Create((double i, double j, double k) vec, nilnul.num.real.re_.approx_.Ratio8dbl ratio)
			{

				if (ratio.re(vec.Variance(), 1))
				{
					return new Unial8dbl(vec);
				}

				throw new ArgumentOutOfRangeException($"{vec} is not 1 by ratio:{ratio.ratio.realee.ee};");
			}



		}


	}
