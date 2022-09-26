using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num._real.approach.be_
{
	/// <summary>
	/// terms
	/// </summary>
	[Obsolete("terms shall be defined on stream; here we define the limite", false)]
	public class Nonneg : BeI
	{

		static public readonly Nonneg Singleton = SingletonByDefault<Nonneg>.Instance;
		[MayPerpetual]
		public bool be(ApproachI1 obj)
		{

			return SignOfTerminalTerms.Eval(obj) >= 0;
			
				;
			throw new NotImplementedException();
		}

		public class En : nilnul.be.Asserted<ApproachI1, Nonneg>
			,ApproachI1
		{
			

			public En(BigInteger a)
				:this(new approach_.Quotient(a))
			{
				
			}

			public En(ApproachI1 val) : base(val)
			{
			}

			public Nonempty.En bound
			{
				get
				{
					return val.bound;
				//	throw new NotImplementedException();
				}
			}

		

			public void clamp(Positive1.En diameter)
			{
				val.clamp(diameter);
				;
				return;
				//
				//throw new NotImplementedException();
			}



			
		}

		public class Assert: nilnul.be.Assert_TbeDefault<ApproachI1,Nonneg>
		{

		}


	}
}
