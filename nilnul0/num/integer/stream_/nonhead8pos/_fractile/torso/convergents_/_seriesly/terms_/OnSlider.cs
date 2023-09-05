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

namespace nilnul.num.integer.stream_.nonhead8pos._fractile.torso.convergents_._series.terms_
{

	/// <summary>
	/// </summary>
	public class OnSlider
		:
		obj.StreamI2<DenomNonnil>
	{
		nilnul.bit.stream_.slider_.Alter _sign = new bit.stream_.slider_.alter_.OneNil();
		nilnul.num.integer.stream_.nonhead8pos._fractile.torso._convergent.divisors.AsSlider _divisors;


		/// <summary>
		/// the adders; assume it's started;
		/// </summary>
		/// <param name="val">
		/// plural;
		/// </param>
		private OnSlider(nilnul.num.integer.stream_.nonhead8pos._fractile.torso._convergent.divisors.AsSlider x)
		{
			_divisors = x;

		}

		public OnSlider(StreamI2<BigInteger> x) : this( _convergent.divisors.AsSlider.OfDenoms(x))
		{

		}

	
	


		public DenomNonnil next()
		{

			return (_sign.next()? 1:-1) / (
				_divisors. current
				*
				  _divisors.next()	
			);
		}
	

	}
}
