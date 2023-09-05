using nilnul.bit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.of_.binary_
{
	public abstract class OfNonneg4dblA :
		ext.of_.Binary4dblA
		
	{

		//[MethodImpl(MethodImplOptions.AggressiveInlining)]

		public abstract double _op_01extNonneg(double par,double par1);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]

		public double op(nilnul.num.real.ext_.Nonneg4dbl x,nilnul.num.real.ext_.Nonneg4dbl x1)
		{
			return _op_01extNonneg(x.errable,x1.errable);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override double op4dbl(Ext4dblI par, Ext4dblI par1)
		{
			return op(new real.ext_.Nonneg4dbl(par), new real.ext_.Nonneg4dbl(par1));
		}
		

	}
}
