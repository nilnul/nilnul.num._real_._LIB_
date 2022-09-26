
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num.real.be_.nonneg.vow;

namespace nilnul.num.real_.nonneg_
{
	public interface PositiveDblI
		:real_.NonnegOfDoubleI
		
	{
		nilnul.num.real.be.en_.BeDefaultedDbl<nilnul.num.real.be_.PositiveDbl> dblen { get; }
	}

	public class PositiveDbl : 
		nilnul.num.real.be.en_.BeDefaultedDbl<nilnul.num.real.be_.PositiveDbl>
		,
		PositiveDblI
	{

		public PositiveDbl(double val) : base(val)
		{
		}

		public nilnul.num.real.be.en_.BeDefaultedDbl<nilnul.num.real.be_.PositiveDbl> dblen => this;

		public EeOfDouble realee => new EeOfDouble(this);

		static public bool operator ==(  PositiveDbl nonneg, int a ) {
			return (nonneg.boxed== a);
		}

		static public bool operator ==( int a, PositiveDbl nonneg ) {
			return  nonneg ==a;
		}

		static public bool operator !=(  PositiveDbl nonneg, int a ) {
			return !(nonneg == a);
		}

		static public bool operator !=(int a,   PositiveDbl nonneg  ) {
			return nonneg != a;
		}


	}
}