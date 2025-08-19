using nilnul.bit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.of_.unary_
{
	public abstract class OfPositive4dblA :
		ext.of_.Unary4dblA
		
	{


		public abstract double _op_0extPositive(double par);


		public double op(nilnul.num.real.ext_.Positive4dbl x)
		{
			return _op_0extPositive(x.errable);
		}

		public override double op4dbl(Ext4dblI par)
		{
			return op(new real.ext_.Positive4dbl(par));
		}
		

	}
}
