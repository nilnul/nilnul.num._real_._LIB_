using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using R = nilnul.num.RealI2;

namespace nilnul.num._real.approach.op_._cube
{
	

		public class Call
			: Arg
			,
			ApproachI1

		{

		private ApproachI1 _asPow;

		public ApproachI1 asPow
		{
			get { return _asPow; }
			private set { _asPow = value; }
		}

		public Call(ApproachI1 arg) : base(arg)
			{

			_asPow = duo.op_.Pow.Eval(arg,3);

			}

			public Nonempty.En bound
			{
				get
				{
					return _asPow.bound;

					throw new NotImplementedException();
				}
			}

			public void clamp(Positive1.En diameter)
			{
				 _asPow.clamp(diameter);
				return;
				throw new NotImplementedException();
			}
		
	}

	public static class CallX
	{
		static public ApproachI1 Cube(this ApproachI1 x) {
			return new Call(x);
		}

	}
}
