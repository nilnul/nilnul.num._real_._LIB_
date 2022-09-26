using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.be_.nonnil.vow;
using nilnul.num.quotient;
using nilnul.num.quotient_;
using System.Numerics;

namespace nilnul.num.real_
{
	public interface NonnilI
		:nilnul.num.RealI
	{
		nilnul.num.real.be_.nonnil.vow.En real { get; }

	}

	public class Nonnil 
		: 
		nilnul.num.real.be_.nonnil.vow.En
		,NonnilI
		,
		RealI
	{

		public En real => this;

		public num.quotient.bound_.Closed current => this.en.current;

		public Nonnil(num.RealI val) : base(val)
		{
		}
		public Nonnil(nilnul.num.real_.Quotient q):this(( num.RealI)q)
		{
		}

		public Nonnil(nilnul.num.Quotient1 q):this(
			new nilnul.num.real_.Quotient(q)
		)
		{
		}


		public Nonnil( int num,int den):this(
			new nilnul.num.Quotient1(num,den)
		)
		{
		}
		public Nonnil( BigInteger num):this(
			new nilnul.num.Quotient1(num)
		)
		{
		}

		public void squeeze(num.quotient_.Positive1 diameter)
		{
			this.en.squeeze(diameter);
		}
		static public RealI operator -(Real real, Nonnil nonnil) {
			return real - (RealI)nonnil;
		}

		static public RealI operator -(RealI real, Nonnil nonnil) {
			return real.ToReal() - nonnil;
		}
		static public RealI operator -( Nonnil nonnil, Real real) {
			return (RealI)nonnil - real;
		}

		static public RealI operator -( Nonnil nonnil, RealI real) {
			return nonnil - real.ToReal();
		}

		static public bool operator <( Nonnil nonnil, int i) {
			return nonnil.ToReal()<i;
		}


		static public bool operator >( Nonnil nonnil, int i) {
			return nonnil.ToReal()>i;
		}

		static public bool operator <( int i,Nonnil nonnil) {
			return i<nonnil.ToReal();
		}
		static public bool operator >( int i,Nonnil nonnil) {
			return i>nonnil.ToReal();
		}

	}
}