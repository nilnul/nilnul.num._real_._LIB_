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

namespace nilnul.num.integer.stream_.nonhead8pos.fractile._convergents
{
	/// <summary>
	/// initially the current is at index: -1
	/// </summary>
	/// <seealso cref="quotient.seq_.fractile._convergent._Divisors"/>
	public class _Divisors

	{
		BigInteger _prev = 1;

		public ref BigInteger prev { get { return ref _prev; } }

		BigInteger _current = 0;

		public ref BigInteger current { get { return ref _current; } }

		public void moveNext(BigInteger adder)
		{
			 _current = _prev + (_prev = _current) * adder;
		}

		/// <summary>
		///  next has to be called to get the convergent0
		/// </summary>
		/// <param name="adder"></param>
		/// <returns></returns>
		public BigInteger next(BigInteger adder)
		{
			return _current = _prev + (_prev = _current) * adder;
		}



	}


}
