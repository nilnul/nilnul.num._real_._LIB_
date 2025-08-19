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
	public interface NonnilI_onQuotient
		:nilnul.num.RealI_onQuotient
	{
		nilnul.num.real.be_.nonnil.vow.Ee_onQuotient real { get; }

	}

	public class Nonnil_onQuotient 
		: 
		nilnul.num.real.be_.nonnil.vow.Ee_onQuotient
		,NonnilI_onQuotient
	
	{

		public nilnul.num.real.be_.nonnil.vow.Ee_onQuotient real => this;

		public 	(Q4 begin, Q4 end) current => this.eeByRef.current; 

		public Nonnil_onQuotient(num.RealI_onQuotient val) : base(val)
		{
		}

		public Nonnil_onQuotient(nilnul.num.real_.Quotient_denomNonnil q):base(q)
		{
		}

		public Nonnil_onQuotient(nilnul.num.quotient_.DenomNonnil q):this(
			new nilnul.num.real_.Quotient_denomNonnil(q)
		)
		{
		}


		public Nonnil_onQuotient( int num,int den):this(
			new nilnul.num.quotient_.DenomNonnil(num,den)
		)
		{
		}
		public Nonnil_onQuotient( BigInteger num):this(
			new nilnul.num.quotient_.DenomNonnil(num)
		)
		{
		}

		public Nonnil_onQuotient(DenomNonnilI scale1):this(
			nilnul.num.quotient_.denomNonnil._ExtensionsX.ToImpl(scale1)
		)
		{
		}

		public Nonnil_onQuotient(Ee_onQuotient arg1):base(arg1.eeByRef)
		{
		}

		public void cinch(num.quotient_.denomNonnil_.Positive diameter)
		{
			this.eeByRef.cinch(diameter);
		}

	

		static public RealI_onQuotient operator -(Real_onQuotient real, Nonnil_onQuotient nonnil) {
			return real - (RealI_onQuotient)nonnil;
		}

		static public RealI_onQuotient operator -(RealI_onQuotient real, Nonnil_onQuotient nonnil) {
			return real.ToImpl() - nonnil;
		}
		static public RealI_onQuotient operator -( Nonnil_onQuotient nonnil, Real_onQuotient real) {
			return (RealI_onQuotient)nonnil - real;
		}

		static public RealI_onQuotient operator -( Nonnil_onQuotient nonnil, RealI_onQuotient real) {
			return nonnil - real.ToImpl();
		}

		static public bool operator <( Nonnil_onQuotient nonnil, int i) {
			return nonnil.ToImpl()<i;
		}


		static public bool operator >( Nonnil_onQuotient nonnil, int i) {
			return nonnil.ToImpl()>i;
		}

		static public bool operator <( int i,Nonnil_onQuotient nonnil) {
			return i<nonnil.ToImpl();
		}
		static public bool operator >( int i,Nonnil_onQuotient nonnil) {
			return i>nonnil.ToImpl();
		}

	}
}