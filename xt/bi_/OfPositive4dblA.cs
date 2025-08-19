using nilnul.bit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.of_.binary_
{
	public abstract class OfPositive4dblA :
		ext.of_.Binary4dblA
		
	{


		public abstract double _op_01extPositive(double par,double par1);


		public double op(nilnul.num.real.ext_.Positive4dbl x,nilnul.num.real.ext_.Positive4dbl y)
		{
			return _op_01extPositive(x.errable,y.errable);
		}

		public override double op4dbl(Ext4dblI par, Ext4dblI par1)
		{
			return op(new real.ext_.Positive4dbl(par),new real.ext_.Positive4dbl(par1));
		}
		

	}
}
