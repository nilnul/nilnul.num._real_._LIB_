using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI3;
using C = nilnul.num._real.CauchyI2;


namespace nilnul.num.real.op_.unary_._square
{


	public class Of
		: nilnul.num.real._call.Arg
		, R
	{
		public Of(R arg) : base(arg)
		{

		}

		public C choice
		{
			get
			{
				return  nilnul.num._real.cauchy.op_.unary_._SquareX.Cauchy(arg.choice);

				//throw new NotImplementedException();
			}
		}
		public override string ToString()
		{
			return $"({arg})**2";
		}
	}


}
