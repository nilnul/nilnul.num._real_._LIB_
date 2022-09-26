
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
	public interface NonnegI
		:
		nilnul.num.RealI
	{
		nilnul.num.real.be_.nonneg.vow.En realee { get; }
	}

	public class Nonneg : 
		nilnul.num.real.be_.nonneg.vow.En
		,
		NonnegI
	{

		public En realee => this;

		public num.quotient.bound_.Closed current => en.current;

		public Nonneg(num.RealI val) : base(val)
		{
		}

		public Nonneg(NonnegI nonneg):base(nonneg)
		{

		}

		public Nonneg(nilnul.num.QuotientI1 q):this(new nilnul.num.Real(q) )
		{

		}

		public Nonneg(int v):this( new nilnul.num.real_.Quotient(v))
		{
		}
		public Nonneg():this(0)
		{

		}

		public void squeeze(num.quotient_.Positive1 diameter)
		{
			en.squeeze(diameter);
		}

		static public bool operator ==(  Nonneg nonneg, int a ) {
			return nilnul.num.real.Eq.Singleton.eq(nonneg, a);
		}

		static public bool operator ==( int a, Nonneg nonneg ) {
			return  nonneg ==a;
		}


		static public bool operator !=(  Nonneg nonneg, int a ) {
			return !(nonneg == a);
		}
		static public Nonneg operator *(  Nonneg nonneg, nilnul.num.QuotientI1 a ) {
			return new Nonneg( nonneg.ToReal()*a );
		}
		static public Nonneg operator *(   nilnul.num.QuotientI1 a , Nonneg nonneg) {
			return nonneg * a;
		}


		static public bool operator !=(int a,   Nonneg nonneg  ) {
			return nonneg != a;
		}

		static public Nonneg Abs(RealI rotation)
		{
			return new Nonneg(
				nilnul.num.real.op_.unary_.Abs.Singleton.op(
					rotation
				)
			);
		}
	}
}