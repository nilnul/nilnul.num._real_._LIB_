using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.stream_._cauchy;
using R = nilnul.num.RealI2;
using C = nilnul.num._real.CauchyI2;
using A = nilnul.num._real._cauchy.ApproachI;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num._real.cauchy_.tg_
{

	public class Of : 
		nilnul.obj.Box<Q1>,
		C 
	{
		public Of(Q1 arg) : base(arg)
		{
		}

		public A approach =>   throw	new NotImplementedException();
			

		public Quotient1 next()
		{
			throw new NotImplementedException();

		}
	}

}
