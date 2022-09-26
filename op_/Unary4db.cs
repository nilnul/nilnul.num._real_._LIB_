using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_
{
	public class Unary4dbl
		:
		nilnul.obj.op_.Unary<double>
		,
		nilnul.num.real.op_.Unary4dblI

	{
		public Unary4dbl(Func<double, double> val) : base(val)
		{
		}
	}



}
