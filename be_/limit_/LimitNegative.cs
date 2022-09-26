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
	public class LimitNegative : BeI
	{

		static public readonly LimitNegative Singleton = SingletonByDefault<LimitNegative>.Instance;
		[MayPerpetual]
		public bool be(ApproachI1 obj)
		{
			return  SignOfLimit.Eval(obj)<0;
//			throw new NotImplementedException();
		}

		public class En : nilnul.be.Asserted<ApproachI1, LimitNegative>
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

			public nilnul.num.quotient.range.be_.NoZero.En bound_noApproachZero {
				get {
					return new quotient.range.be_.NoZero.En(
						val.bound	
					);
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

		public class Assert: nilnul.be.Assert_TbeDefault<ApproachI1,LimitNegative>
		{

		}


	}
}
