
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_.ext.bound.couple.be
{
	public class Interval

	{
		static public bool Eval(Couple couple) {

			return NoExtreme.Eval(couple) && Has.Eval(couple);
			
		}

		public class Be:nilnul.bit.Be<Couple>
		{
			public Be()
				:base(Eval)
			{

			}
		}

		public class Asserted:nilnul.bit.be.Asserted<Couple,Be>
		{
			public Asserted(Couple couple)
				:base(couple)
			{
			}

			public Asserted(Bound lower, Bound upper)
				:this(new Couple(lower, upper))
			{

			}

			public Asserted(double a, bool leftEq, double b, bool rightEq)
				:this(

					 new Couple(
					new double_.ext.Bound(a,leftEq)
					 ,
					new double_.ext.Bound(b,rightEq)	 )
				 )
			{

			}

			public bool contains(double b) {
				return val.contains(b);
			}

			public Bound lower {
				get { return val.lower; }
			}

			public Bound upper {
				get { return val.upper; }
			}



		}




	}
}
