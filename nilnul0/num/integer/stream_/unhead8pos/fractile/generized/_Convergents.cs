using nilnul.num.quotient_;
using nilnul.obj._stream_._next;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.nonhead8pos.fractile.generalized
{

	/// <summary>
	/// </summary>
	/// <remarks>
	/// as namespace, using streamy to euphemism <see cref="num.quotient.stream"/>
	/// </remarks>
	public class _Convergents
		:
		nilnul.obj.Box_ofIn<
			nilnul.obj.StreamI2<(BigInteger, BigInteger)>
		>
		,
		nilnul.num.quotient_.denomNonnil.stream_._slider.SkidI
		,
		nilnul.num.quotient_.denomNonnil.StreamI

		,
		IConvergents


	{
		_convergents._Divisors _lowers = new _convergents._Divisors();
		_convergents._Dividends _uppers;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">
		/// nonhead positive;
		/// </param>
		public _Convergents(BigInteger head, nilnul.obj.StreamI2<(BigInteger, BigInteger)> val) : base(val)
		{
			_lowers = new _convergents._Divisors();
			_uppers = new _convergents._Dividends(head);
		}

		public DenomNonnil current => new DenomNonnil(
				_uppers.current
				,
				_lowers.current
			);


		public void moveNext()
		{
			var t = boxed.next();
			_uppers.moveNext(
				t.Item2
				,
				t.Item1
			)
			;
			_lowers.moveNext(
				t.Item2
				,
				t.Item1
			);
		}

		public DenomNonnil next()
		{
			return nilnul.obj.stream_._slider.SkimX.Next(this);
		}


	}
}
