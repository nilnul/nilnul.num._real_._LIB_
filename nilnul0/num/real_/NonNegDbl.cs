
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num.real.be_.nonneg.vow;

namespace nilnul.num.real_
{
	public interface NonnegOfDoubleI
		
	{
		nilnul.num.real.be_.nonneg.vow.EeOfDouble realee { get; }
	}

	public class NonnegOfDouble : 
		nilnul.num.real.be_.nonneg.vow.EeOfDouble
		,
		NonnegOfDoubleI
		,
		_real_.DblI
	{

		public NonnegOfDouble(double val) : base(val)
		{
		}

		public EeOfDouble realee => this;

		public double Dbl => this.ee;

		static public bool operator ==(  NonnegOfDouble nonneg, int a ) {
			return (nonneg.boxed== a);
		}

		static public bool operator ==( int a, NonnegOfDouble nonneg ) {
			return  nonneg ==a;
		}

		static public bool operator !=(  NonnegOfDouble nonneg, int a ) {
			return !(nonneg == a);
		}

		static public bool operator !=(int a,   NonnegOfDouble nonneg  ) {
			return nonneg != a;
		}

		static public NonnegOfDouble CreateByAbs(double x) {
			return new NonnegOfDouble(x>=0?x:-x);
		}


	}
}