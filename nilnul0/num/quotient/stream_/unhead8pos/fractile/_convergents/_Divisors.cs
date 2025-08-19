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

namespace nilnul.num.quotient.stream_.nonhead8pos.fractile._convergents
{
	/// <summary>
	/// initially the current is at index: -1
	/// </summary>
	/// <seealso cref="quotient.seq_.fractile._convergent._Divisors"/>
	public class _Divisors
		:
		nilnul.obj.IStream // initially the current is index -1, not index 0
	{
		num.quotient_.DenomNonnil _prev = 1;

		public ref num.quotient_.DenomNonnil prev { get { return ref _prev; } }

		num.quotient_.DenomNonnil _current = 0;

		public ref num.quotient_.DenomNonnil current { get { return ref _current; } }

		public void moveNext(num.quotient_.DenomNonnil adder)
		{
			 _current = _prev + (_prev = _current) * adder;
		}

		/// <summary>
		///  next has to be called to get the convergent0
		/// </summary>
		/// <param name="adder"></param>
		/// <returns></returns>
		public num.quotient_.DenomNonnil next(num.quotient_.DenomNonnil adder)
		{
			return _current = _prev + (_prev = _current) * adder;
		}



	}


}
