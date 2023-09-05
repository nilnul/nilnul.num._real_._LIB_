using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.nonhead8pos.fractile_.periodic_._golden._adders
{
	public class Denoms
		:
		nilnul.num.integer.StreamI1
	{
		public BigInteger next()
		{
			return 1;
		}


		/// <summary>
		/// this has no ascernible state;
		/// </summary>
		static public Denoms Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Denoms>.Unison;
			}
		}

	}
}
