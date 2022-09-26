using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.nonneg_.ltOne.vow
{
	public class EeDbl : nilnul.num.real.vow.EeOfDouble<ltOne.VowDbl>
	{
		public EeDbl(double val) : base(val)
		{
		}

		static public bool operator ==(EeDbl real, int i){
			return real.ee == i;
		}
		static public bool operator !=(EeDbl real, int i){
			return ! (real == i);
		}

		static public bool operator ==( int i, EeDbl real)
		{
			return real == i;
		}
		static public bool operator !=( int i, EeDbl real)
		{
			return ! (i ==real);
		}


	}
}
