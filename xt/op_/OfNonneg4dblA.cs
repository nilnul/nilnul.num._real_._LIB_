using nilnul.bit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.of_.unary_
{
	public abstract class OfNonneg4dblA :
		ext.of_.Unary4dblA
		
	{

		//[MethodImpl(MethodImplOptions.AggressiveInlining)]

		public abstract double _op_0extNonneg(double par);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]

		public double op(nilnul.num.real.ext_.Nonneg4dbl x)
		{
			return _op_0extNonneg(x.errable);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override double op4dbl(Ext4dblI par)
		{
			return op(new real.ext_.Nonneg4dbl(par));
		}
		

	}
}
