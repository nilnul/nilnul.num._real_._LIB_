using nilnul.bit;
using nilnul.num.quotient_;
using nilnul.num.quotient_._recurFrac;
using nilnul.obj;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.nonhead8pos._fractile.torso.convergents_._series
{

	/// <summary>
	/// </summary>
	public class Terms
		:
		obj.StreamI2<DenomNonnil>
	{
		nilnul.bit.stream_.slider_.Alter _sign = new bit.stream_.slider_.alter_.OneNil();
		nilnul.num.integer.stream_.nonhead8pos._fractile.torso._convergent._Divisors _lowers;

		private DenomNonnil _current;

		/// <summary>
		/// the adders; assume it's started;
		/// </summary>
		/// <param name="val">
		/// plural;
		/// </param>
		private Terms(nilnul.num.integer.stream_.nonhead8pos._fractile.torso._convergent._Divisors x)
		{
			_lowers = x;
			_current = x.next();
		}

		private Terms(StreamI2<BigInteger> x) : this(new _convergent._Divisors(x))
		{

		}

	
	


		public DenomNonnil next()
		{

			return (_sign.next()? 1:-1) / (
				_current
				*
				(_current= _lowers.next()	)
			);
		}
	

	}
}
