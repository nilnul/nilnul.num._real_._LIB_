using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.nonhead8pos.fractile_.periodic_._golden.adders_.slider_
{
	public class Peek
		:
		Slider
		,
		nilnul.obj.stream_.slider_.PeekI<BigInteger>
	{
	

		/// <summary>
		/// this has no ascernible state;
		/// </summary>
		static public Peek Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Peek>.Unison;
			}
		}

		public BigInteger ahead => 1;
	}
}
