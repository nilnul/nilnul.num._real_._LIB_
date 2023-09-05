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

namespace nilnul.num.integer.stream_.nonhead8pos._fractile.torso._convergent._divisors
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="quotient.seq_.fractile._convergent._Divisors"/>
	public class _Iterator

	{
		BigInteger _prev = 1;

		BigInteger _current = 0;

		public BigInteger next(BigInteger adder)
		{
			return _current = _prev + (_prev = _current) * adder;
		}
	}


}
