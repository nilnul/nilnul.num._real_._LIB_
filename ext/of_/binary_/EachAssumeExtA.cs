using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.of_.binary_
{
	public abstract class EachAssumeExtA
		:
		Binary4dblA
		,
		of_.Binary4dblI
		,
		_eachExt_.Op_eachExtI
	{
		public abstract double _op_01ext(double a, double b);
		public override double op4dbl(Ext4dblI par, Ext4dblI par1)
		{
			return  _op_01ext(par.errable,par1.errable);
		}

	}
}
