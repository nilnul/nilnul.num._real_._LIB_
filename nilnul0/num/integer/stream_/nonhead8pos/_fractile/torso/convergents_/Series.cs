using nilnul.num.quotient_;
using nilnul.obj.stream_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.nonhead8pos._fractile.torso.convergents_
{
	public class Series
		:

		nilnul.num.quotient_.denomNonnil.stream_.SliderA
	{

		/// <summary>
		/// this is an alternate stream; the residue for this series would be le the current last term.
		/// </summary>
		_series.terms_.OnSlider _terms;
		public Series(_series.terms_.OnSlider val)
		{
			_terms = val;
		}

		public Series(obj.StreamI2<BigInteger> adders) : this(new _series.terms_.OnSlider(adders))
		{
		}

		DenomNonnil _current = 0;

		/// <summary>
		/// 
		/// </summary>
		public override DenomNonnil current => _current;



		/// <summary>
		/// the 1st item of this is 
		/// </summary>
		public override void moveNext()
		{
			_current += _terms.next();
		}
	}
}
