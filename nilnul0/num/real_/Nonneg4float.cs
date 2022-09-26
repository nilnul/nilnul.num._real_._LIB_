
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
	public interface Nonneg4floatI
		
	{
		nilnul.num.real.be_.nonneg.vow.Ee4float realee { get; }
	}

	public class Nonneg4float : 
		nilnul.num.real.be_.nonneg.vow.Ee4float
		,
		Nonneg4floatI
		//,
		//_real_.DblI
	{

		public Nonneg4float(float val) : base(val)
		{
		}

		public Ee4float realee => this;

		public float val => this.ee;

		static public bool operator ==(Nonneg4float nonneg, int a ) {
			return (nonneg.boxed== a);
		}

		static public bool operator ==( int a, Nonneg4float nonneg ) {
			return  nonneg ==a;
		}

		static public bool operator !=(Nonneg4float nonneg, int a ) {
			return !(nonneg == a);
		}

		static public bool operator !=(int a, Nonneg4float nonneg  ) {
			return nonneg != a;
		}

		static public Nonneg4float CreateByAbs(float x) {
			return new Nonneg4float(x>=0?x:-x);
		}


	}
}