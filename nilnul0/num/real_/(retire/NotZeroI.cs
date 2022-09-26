using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach.generator;
using nilnul.num._real.approach.generator_;

namespace nilnul.num.real_
{
	[Obsolete()]
	public interface NotZeroI
		:nilnul.num.RealI2
	{

		nilnul.num._real.approach.generator_.NotZeroI choice { get; }

	}
	[Obsolete()]

	public class NotZero : num.real.be.En<num.real.be_.NotZero>
		,NotZeroI
	{
		private num._real.approach.generator_.NotZero _generator;

		public num._real.approach.generator_.NotZero generator
		{
			get { return _generator; }
			set { _generator = value; }
		}

		public _real.approach.generator_.NotZeroI choice
		{
			get
			{
				return _generator;
				throw new NotImplementedException();
			}
		}

		GeneratorI CofinalI.choice
		{
			get
			{
				return choice;
				throw new NotImplementedException();
			}
		}

		public NotZero(num.RealI2 val) : base(val)
		{
			_generator = new nilnul.num._real.approach.generator_.NotZero(val.choice);



		}



		public NotZero(nilnul.num.Quotient q):this(
			new nilnul.num.real_.Quotient(q)
			
		)
		{

		}


		public NotZero( int num,int den):this(
			new nilnul.num.Quotient(num,den)
			
		)
		{

		}


		

		
	}


}
