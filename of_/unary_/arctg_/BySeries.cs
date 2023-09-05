using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.unary_.arctg_
{
	public class BySeries : real.op_.UnaryI
	{

		public RealI ofAbsLeOne(RealI real) {
			if (nilnul.num.real.be_.Quotient.Singleton.be(real) )
			{
				return num.real.convert_.arctg_._OfQuotientX._ofAbsLeOne(real.current.lower.mark);
			}
			return new _bySeries.ret_.OfAbsLeOne(real);
		}

		public RealI ofGe1Unsure1(RealI _ge1) {

				return nilnul.num.real_.TauX.Quarter -  ofAbsLeOne(1 / _ge1.ToReal());

		}

		public RealI op___assume__Positive_DiameterLe4Tenth(RealI par)
		{

			if (par.current.lower.mark < (1))
			{
				if (par.current.upper.mark > 1)
				{

					return new arctg_._ofAbsCircaOne.ret_.OfDiameterLe4Tenth(par);

				}
				return ofAbsLeOne(par);

			}
			else if (par.current.lower.mark > 1)
			{
				return ofGe1Unsure1(par);// nilnul.num.real_.TauX.Quarter -  ofAbsLeOne(1 / par.ToReal());
			}
			else   //==1
			{
				if (par.current.upper.mark ==1)
				{
					return nilnul.num.real_.TauX.Eighth;
				}
				return ofGe1Unsure1(par);


			}

		}


		public RealI op(RealI par)
		{


			par.Clamp(nilnul.num.Quotient1.CreateByDivide(4, 10));       // in ( tg(tau/12) = 1/cubicRoot(3) ,  tg(tau/6) = cubicRoot(3) )

			if (par.current.containsZero())
			{
				if (nilnul.num.quotient.bound_.closed.be_.Nil.Singleton.be(par.current) )
				{
					return new nilnul.num.real_.Quotient();
				}

				return ofAbsLeOne(par);
			}
			if (par.current.lower.mark > 0)
			{
				return op___assume__Positive_DiameterLe4Tenth(par);

			}
			// <0
			return -op___assume__Positive_DiameterLe4Tenth(-par.ToReal()).ToReal();


		}

		static public BySeries Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BySeries>.Instance;
			}
		}


	}
}
