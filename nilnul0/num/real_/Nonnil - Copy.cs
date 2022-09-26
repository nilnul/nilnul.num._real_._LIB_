using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach.generator;
using nilnul.num._real.approach.generator_;
using nilnul.num._real;
using nilnul.num.real.be_.nonnil.vow;

namespace nilnul.num.real_
{
	[Obsolete()]
	public interface NonnilI
		:nilnul.num.RealI3
	{

		nilnul.num.real.be_.nonnil.vow.En nonnil { get; }

	}

	[Obsolete()]
	public class Nonnil 
		: 
		nilnul.num.real.be_.nonnil.vow.En
		,NonnilI
		,
		RealI3
	{
		private num._real.approach.generator_.NotZero _generator;

		public num._real.approach.generator_.NotZero generator
		{
			get { return _generator; }
			set { _generator = value; }
		}

		public CauchyI2 choice => en.choice;

		

		public En nonnil => this;


		public Nonnil(num.RealI3 val) : base(val)
		{


		}
		public Nonnil(nilnul.num.real_.Quotient1 q):this(( num.RealI3)q)
		{

		}


		public Nonnil(nilnul.num.Quotient1 q):this(
			new nilnul.num.real_.Quotient1(q)
			
		)
		{

		}


		public Nonnil( int num,int den):this(
			new nilnul.num.Quotient1(num,den)
			
		)
		{

		}

		
	}


}
