using nilnul.num.quotient_;
using nilnul.obj._stream_._next;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.nonhead8pos.fractile
{

	/// <summary>
	/// </summary>
	/// <remarks>
	/// as namespace, using streamy to euphemism <see cref="num.quotient.stream"/>
	/// </remarks>
	public class _Convergents
		:
		nilnul.obj.Box_ofIn<
			nilnul.obj.StreamI2<BigInteger>
		>
		,
		nilnul.num.quotient_.denomNonnil.StreamI
		,
		IConvergents 


	{
		_convergents._Divisors _lowers = new _convergents._Divisors();
		_convergents._Dividends _uppers = new _convergents._Dividends();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">
		/// nonhead positive;
		/// </param>
		public _Convergents(nilnul.obj.StreamI2<BigInteger> val) : base(val)
		{
			//_numerators = new _stream._Lowers();
			//_denominators = new  _stream._Uppers();
		}


		public DenomNonnil next()
		{
			var t = boxed.next();
			return new DenomNonnil(
				_uppers.next(
					t
				)
				,
				_lowers.next(
					t
				)
			);
		}


	}
}
