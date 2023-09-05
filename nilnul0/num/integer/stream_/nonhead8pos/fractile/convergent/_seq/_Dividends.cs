using nilnul.obj.stream_._slider._skim_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using nilnul.obj.stream_._slider._skim_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace nilnul.num.integer.stream_.nonhead8pos.fractile.convergent._seq
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="quotient.seq_.fractile._convergent._Dividends"/>

	public class _Dividends


			:
			nilnul.obj._seq_.GetEnumeratorA<BigInteger>
			,
			IEnumerable<BigInteger>

	{
		/// <summary>
		/// the previous adder; initialized as 0;
		/// </summary>
		BigInteger _prev = 0;



		BigInteger _current = 1;

		/// <summary>
		/// the current value of adders; 
		/// </summary>

		IEnumerable<BigInteger> _adders;    //started;


		public _Dividends(IEnumerable<BigInteger> adders_)
		{
			_adders = adders_;
		}



		/// <summary>
		/// we get an enumerator|slider from the underlying seq;
		/// </summary>
		/// <returns></returns>
		public override IEnumerator<BigInteger> GetEnumerator()
		{
			var enumer = _adders.GetEnumerator();
			while (true)
			{
				enumer.MoveNext();
				yield return _current = _prev + (_prev = _current) * enumer.Current;      /// initially, this is a0.

			}
		}
	}
}
