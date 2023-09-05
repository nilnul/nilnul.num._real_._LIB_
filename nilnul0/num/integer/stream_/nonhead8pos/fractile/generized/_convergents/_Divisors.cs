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
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace nilnul.num.integer.stream_.nonhead8pos.fractile.generalized._convergents
{
	/// <summary>
	/// intially the current is convergent[0]
	/// </summary>
	/// <seealso cref="quotient.seq_.fractile._convergent._Divisors"/>
	public class _Divisors

	{
		BigInteger _prev = 0;

		public ref BigInteger prev { get { return ref _prev; } }

		BigInteger _current = 1;

		public ref BigInteger current { get { return ref _current; } }

		/// <summary>
		/// numer[1] doesnot impact divisor.
		/// Note: we have no numer[0], the first numer is numer[1].
		/// </summary>
		/// <param name="adder"></param>
		/// <param name="numer"></param>
		public void moveNext(BigInteger adder,BigInteger numer)
		{
			 _current = _prev*numer + (_prev = _current) * adder;
		}

		public BigInteger seek(BigInteger adder,BigInteger numer)
		{
			moveNext(adder, numer);
			return _current;
		}



	}


}
