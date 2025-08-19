using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.re_
{
	/// <summary>
	/// one is negative, the other is positive.
	/// </summary>
	///
	
	public class Opposite
		:
		nilnul.num.real.ReDblI
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool re(double a, double b)
		{
			return a < 0 ? b > 0 : (a > 0 ? b < 0 : false);
		}


		static public Opposite Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Opposite>.Unison;
			}
		}

	}
}
