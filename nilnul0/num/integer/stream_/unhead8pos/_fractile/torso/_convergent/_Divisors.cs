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
using nilnul.obj;

namespace nilnul.num.integer.stream_.nonhead8pos._fractile.torso._convergent
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="quotient.seq_.fractile._convergent._Divisors"/>
	public class _Divisors
		:
		nilnul.obj.Box_ofIn< nilnul.obj.StreamI2<BigInteger> >
		,
		obj.StreamI2<BigInteger>

	{
		private _divisors._Iterator _iter=new _convergent._divisors._Iterator();

	
		public _Divisors(in StreamI2<BigInteger> val) : base(val)
		{
		}

		public _Divisors(StreamI2<BigInteger> x) : base(x)
		{
		}

		public BigInteger next()
		{
			return _iter.next(boxed.next());
		}
	}


}
