using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num._real.approach;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num._real.approach
{
	[MayPerpetual]
	[Obsolete()]
	public  class SignOfLimit
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="real"></param>
		/// <returns></returns>
		/// 
		[MayPerpetual]
		static public void Proc(ApproachI1 real) {
			//var range = real.bound;

			while (real.bound.containsZero())
			{

				if ( real.bound.isSingleton)
				{
					return;// real;
					
				}

				real.Clamp1K();
				
			}


			while (real.bound.lower.mark==0 || real.bound.upper.mark==0)
			{

				real.Clamp1K();

			}

		}

		
		[MayPerpetual]
		static public int Eval(ApproachI1 real) {

			Proc(real);
			return nilnul.num.quotient.Comparer1.lazy.sign(real.bound.lower.mark);

		}

		static public ApproachI1 Eval_retApproach(ApproachI1 real) {

			while (real.bound.containsZero())
			{

				if (real.bound.isSingleton)
				{
					return new approach_.Quotient();// real;

				}

				real.Clamp1K();

			}


			while (real.bound.lower.mark == 0 || real.bound.upper.mark == 0)
			{

				real.Clamp1K();

			}
			if (real.bound.lower.mark>0)
			{
				return new Ed.Positive(real);

			}

			

			return new Ed.Negative(real);

		}

		public class Ed:ApproachI1
		{
			private ApproachI1 _val;
			private Ed(ApproachI1 x)
			{
				_val = x;
			}

			public Nonempty.En bound
			{
				get
				{
					return _val.bound;

					throw new NotImplementedException();
				}
			}

			public void clamp(Positive1.En diameter)
			{
				_val.clamp(diameter);
				//throw new NotImplementedException();
			}




			public class Positive:Ed
			{
				internal Positive(ApproachI1 x):base(x)
				{

				}

			}



			public class Negative:Ed
			{
				internal Negative(ApproachI1 x):base(x)
				{

				}

				private Negative Create(ApproachI1 x) {
					return new Negative(x);
				}

			}


		}

		




	}
}
