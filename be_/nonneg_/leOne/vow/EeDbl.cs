using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.nonneg_.leOne.vow
{
	public class Ee4dbl : nilnul.num.real.vow.EeOfDouble<leOne.Vow4dbl>
	{
		public Ee4dbl(double val) : base(val)
		{
		}

		static public bool operator ==(Ee4dbl real, int i){
			return real.ee == i;
		}
		static public bool operator !=(Ee4dbl real, int i){
			return ! (real == i);
		}

		static public bool operator ==( int i, Ee4dbl real)
		{
			return real == i;
		}
		static public bool operator !=( int i, Ee4dbl real)
		{
			return ! (i ==real);
		}


	}
}
