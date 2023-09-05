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
	/// <seealso cref="quotient.seq_.fractile._convergent._Divisors"/>
	public class _Divisors

			:
			nilnul.obj._seq_.GetEnumeratorA<BigInteger>
			,
			IEnumerable<BigInteger>

	{
		/// <summary>
		/// the previous adder; initialized as 0;
		/// </summary>
		BigInteger _prev = 1;



		BigInteger _current = 0;

		/// <summary>
		/// the current value of adders; 
		/// </summary>

		IEnumerable<BigInteger> _adders;    //started;


		/// <summary>
		/// 
		/// </summary>
		/// <param name="adders_">stream</param>
		public _Divisors(IEnumerable<BigInteger> adders_)
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
				enumer.MoveNext(); //we don't need the if else;
				/// /: also consider:
				/// :	-the par for the ctor can be a stream such as <see cref="num.integer.stream"/>
				/// :	-we don't need to return an enumer; we can return a stream;
				yield return _current = _prev + (_prev = _current) * enumer.Current;      /// initially, this is 1.
				
			}
	

		}


	}
}
