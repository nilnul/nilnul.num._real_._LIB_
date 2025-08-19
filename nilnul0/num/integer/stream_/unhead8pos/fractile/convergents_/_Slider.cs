using nilnul.num.quotient_;
using nilnul.obj._stream_._next;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.nonhead8pos.fractile.convergents_
{

	/// <summary>
	/// as indicated by the preceding "_", the input must be valid fractile, that is, each torso members must be positive, or else the behavior is undefined;
	/// </summary>
	public class _Slider
		:
		nilnul.obj.Box_ofIn<
			nilnul.obj.stream_.SliderI<BigInteger>
		>
		,

		nilnul.num.quotient_.denomNonnil.stream_.SliderI

	{
		_convergents._Divisors _lowers = new _convergents._Divisors();
		_convergents._Dividends _uppers = new _convergents._Dividends();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">
		/// nonhead positive;
		/// </param>
		public _Slider(nilnul.obj.stream_.SliderI<BigInteger> val) : base(val)
		{
			_uppers.moveNext(boxed.current);
			_lowers.moveNext(boxed.current);

			_current = new DenomNonnil(
				_uppers.current
				,
				_lowers.current
			);

		}

		public DenomNonnil _current ;
		public DenomNonnil current => _current;



		public void moveNext()
		{
			boxed.moveNext();


			_lowers.moveNext(boxed.current);
			_uppers.moveNext(boxed.current);

			_current = new DenomNonnil(_uppers.current, _lowers.current);


		//	throw new NotImplementedException();
		}

		public DenomNonnil next()
		{
			return nilnul.obj.stream_._slider.SkimX.Next(this);
		}


	}
}
