using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.nonneg_.leOne.vow
{
	public class Ee : nilnul.num.real.vow.En<leOne.Vow>
	{
		public Ee(RealI val) : base(val)
		{
		}

		static public bool operator ==(Ee real, int i){
			return real.en.ToReal() == i;
		}
		static public bool operator !=(Ee real, int i){
			return ! (real == i);
		}

		static public bool operator ==( int i, Ee real)
		{
			return real == i;
		}
		static public bool operator !=( int i, Ee real)
		{
			return ! (i ==real);
		}


	}
}
