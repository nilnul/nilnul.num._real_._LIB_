using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.unary.recur
{
	public class Slider4dbl
		:
		nilnul.obj.op_.unary.recur.Slider<op_.unary.Recur4dbl, double, op_.Unary4dblI>,

		nilnul.num.real.stream_.Slider4dblI
	{
		public Slider4dbl(Recur4dbl val) : base(val)
		{
		}

		public Slider4dbl(double initial0, op_.Unary4dblI instance):this(new Recur4dbl(initial0,instance))
		{
		}
	}
}
