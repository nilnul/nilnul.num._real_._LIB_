using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient_;
using System.Numerics;

namespace nilnul.num.real_
{
	public interface NotOneI
		:nilnul.num.RealI
	{
		nilnul.num.real.be_.notOne.vow.En realee { get; }

	}

	public class NotOne 
		: 
		nilnul.num.real.be_.notOne.vow.En
		,NotOneI
		,
		RealI
	{

		public nilnul.num.real.be_.notOne.vow.En realee => this;

		public num.quotient.bound_.Closed current => this.en.current;

		public NotOne(num.RealI val) : base(val)
		{
		}
		public NotOne(nilnul.num.real_.Quotient q):this(( num.RealI)q)
		{
		}

		public NotOne(nilnul.num.Quotient1 q):this(
			new nilnul.num.real_.Quotient(q)
		)
		{
		}


		public NotOne( int num,int den):this(
			 nilnul.num.Quotient1.CreateByDivide(num,den)
		)
		{
		}
		public NotOne( BigInteger num):this(
			new nilnul.num.Quotient1(num)
		)
		{
		}

		public void squeeze(num.quotient_.Positive1 diameter)
		{
			this.en.squeeze(diameter);
		}
		static public RealI operator -(Real real, NotOne nonnil) {
			return real - (RealI)nonnil;
		}

		static public RealI operator -(RealI real, NotOne nonnil) {
			return real.ToReal() - nonnil;
		}
		static public RealI operator -( NotOne nonnil, Real real) {
			return (RealI)nonnil - real;
		}

		static public RealI operator -( NotOne nonnil, RealI real) {
			return nonnil - real.ToReal();
		}

		static public bool operator <( NotOne nonnil, int i) {
			return nonnil.ToReal()<i;
		}


		static public bool operator >( NotOne nonnil, int i) {
			return nonnil.ToReal()>i;
		}

		static public bool operator <( int i,NotOne nonnil) {
			return i<nonnil.ToReal();
		}
		static public bool operator >( int i,NotOne nonnil) {
			return i>nonnil.ToReal();
		}

	}
}