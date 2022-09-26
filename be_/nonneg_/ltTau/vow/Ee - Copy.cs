using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.nonneg_.ltTau.vow
{
	public class EeOfDouble : nilnul.num.real.vow.EeOfDouble<ltTau.VowOfDouble>
	{
		public EeOfDouble(double val) : base(val)
		{
		}

		static public bool operator ==(EeOfDouble real, int i){
			return real.ee == i;
		}
		static public bool operator !=(EeOfDouble real, int i){
			return ! (real == i);
		}

		static public bool operator ==( int i, EeOfDouble real)
		{
			return real == i;
		}
		static public bool operator !=( int i, EeOfDouble real)
		{
			return ! (i ==real);
		}


	}
}
