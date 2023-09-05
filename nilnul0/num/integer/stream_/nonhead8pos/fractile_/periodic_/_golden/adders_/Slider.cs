using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.nonhead8pos.fractile_.periodic_._golden.adders_
{
	public class Slider
		:
		nilnul.num.integer.stream_.SliderA
	{
	

		/// <summary>
		/// this has no ascernible state;
		/// </summary>
		static public Slider Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Slider>.Unison;
			}
		}

		public override BigInteger current => 1;

		public override void moveNext()
		{
		}
	}
}
