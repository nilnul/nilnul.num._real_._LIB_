using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient_;
using A = nilnul.num._real._cauchy.ApproachI;

namespace nilnul.num._real._cauchy.approach.op_.unary_._square
{
	public class Of : nilnul.num._real._cauchy.approach._call.Arg
		,
		A
	{
		public Of(ApproachI arg) : base(arg)
		{
		}

		public Range1 range => nilnul.num.quotient.range.op_.binary_._MultiX.Op(arg.range,arg.range);

		public void squeeze(Positive1 diameter)
		{
			while (range.notSpanLessThan(diameter))
			{
				arg.ClampHalf();//.squeeze();

			}

		}
	}
}
