using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real._approach.members;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient.range.be_;
using System.Numerics;

namespace nilnul.num._real.approach_
{

	public interface NotZeroI:ApproachI1

	{
		nilnul.num.quotient.range.be_.NoApproachZero.En range { get; }

		

	}


	public class NotZero 
		: nilnul.be.Asserted<ApproachI1, approach.be_.Nonzero>
	, NotZeroI

	{


		public NotZero(BigInteger a)
			: this(new approach_.Quotient(a))
		{

		}

		public NotZero(ApproachI1 val) : base(val)
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

		public nilnul.num.quotient.range.be_.NoApproachZero.En bound_noApproachZero
		{
			get
			{
				return new quotient.range.be_.NoApproachZero.En(
					val.bound
				);
			}
		}

		public NoApproachZero.En range
		{
			get
			{
				return new quotient.range.be_.NoApproachZero.En(
					val.bound
				);
		
				throw new NotImplementedException();
			}
		}

		

		public void clamp(Positive1.En diameter)
		{

			val.clamp(diameter);
			;
			return;

			throw new NotImplementedException();
		}

		



	}

}
