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

namespace nilnul.num.real.op_.binary_._add.ret_
{
	public class Call :
			nilnul._call.ArgArg1A<nilnul.num.Quotient1,RI>
			,
			RI
	{
		public Call(nilnul.num.Quotient1 arg, RI arg1) : base(arg, arg1)
		{
		}

		public C choice
		{
			get
			{
				return num._real.cauchy.op_.binary_.Add.Singleton.op(arg, arg1.choice);
			}
		}

		public override string ToString()
		{
			return $"{ arg}{ Add.Sign}{ arg1}";
		}
	}
}