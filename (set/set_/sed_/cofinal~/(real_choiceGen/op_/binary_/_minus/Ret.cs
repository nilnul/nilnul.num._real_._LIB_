using nilnul.num._real.approach;
using nilnul.num.quotient.stream_;
using nilnul.num.rational;
using nilnul.num.rational.accuracy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.Real1;

using RI = nilnul.num.RealI3;
using C = nilnul.num._real.CauchyI2;


namespace nilnul.num.real.op_.binary_._minus
{
	public class Ret :
			nilnul._call.argArg1_.Closed<RI>
			,
			RI
	{

		public Ret(RI arg, RI arg1) : base(arg, arg1)
		{
		}

		public C choice
		{
			get
			{
				return nilnul.num._real.cauchy.op_.binary_.Minus.Singleton.op(arg.choice, arg1.choice);
			}
		}


		public override string ToString()
		{
			return $"{ arg}{ Minus.Sign}{ arg1}";
		}

	}
}
