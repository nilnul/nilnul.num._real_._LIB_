using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.be_.nonnil.vow;
using nilnul.num.quotient;
using nilnul.num.quotient_;
using System.Numerics;
using nilnul.obj.stream_._slider._skid_;
using nilnul.num.real;

namespace nilnul.num.real_
{
	public interface NonnegI_onQuotient
		:nilnul.num.RealI_onQuotient
	{
		nilnul.num.real.be_.nonneg.vow.Ee_onQuotient real { get; }

	}

	public class Nonneg_onQuotient 
		: 
		nilnul.num.real.be_.nonneg.vow.Ee_onQuotient
		,NonnegI_onQuotient
	
	{

		public nilnul.num.real.be_.nonneg.vow.Ee_onQuotient real => this;

		public 	(Q4 begin, Q4 end) current => this.eeByRef.current; 

		public Nonneg_onQuotient(num.RealI_onQuotient val) : base(val)
		{
		}

		public Nonneg_onQuotient(nilnul.num.real_.Quotient_denomNonnil q):base(q)
		{
		}

		public Nonneg_onQuotient(nilnul.num.quotient_.DenomNonnil q):this(
			new nilnul.num.real_.Quotient_denomNonnil(q)
		)
		{
		}


		public Nonneg_onQuotient( int num,int den):this(
			new nilnul.num.quotient_.DenomNonnil(num,den)
		)
		{
		}
		public Nonneg_onQuotient( BigInteger num):this(
			new nilnul.num.quotient_.DenomNonnil(num)
		)
		{
		}

		public Nonneg_onQuotient(DenomNonnilI scale1):this(
			nilnul.num.quotient_.denomNonnil._ExtensionsX.ToImpl(scale1)
		)
		{
		}

		public Nonneg_onQuotient(Ee_onQuotient arg1):base(arg1.eeByRef)
		{
		}

		public void cinch(num.quotient_.denomNonnil_.Positive diameter)
		{
			this.eeByRef.cinch(diameter);
		}

	

		static public RealI_onQuotient operator -(Real_onQuotient real, Nonneg_onQuotient nonnil) {
			return real - (RealI_onQuotient)nonnil;
		}

		static public RealI_onQuotient operator -(RealI_onQuotient real, Nonneg_onQuotient nonnil) {
			return real.ToImpl() - nonnil;
		}
		static public RealI_onQuotient operator -( Nonneg_onQuotient nonnil, Real_onQuotient real) {
			return (RealI_onQuotient)nonnil - real;
		}

		static public RealI_onQuotient operator -( Nonneg_onQuotient nonnil, RealI_onQuotient real) {
			return nonnil - real.ToImpl();
		}

		static public bool operator <( Nonneg_onQuotient nonnil, int i) {
			return nonnil.ToImpl()<i;
		}


		static public bool operator >( Nonneg_onQuotient nonnil, int i) {
			return nonnil.ToImpl()>i;
		}

		static public bool operator <( int i,Nonneg_onQuotient nonnil) {
			return i<nonnil.ToImpl();
		}
		static public bool operator >( int i,Nonneg_onQuotient nonnil) {
			return i>nonnil.ToImpl();
		}

	}
}