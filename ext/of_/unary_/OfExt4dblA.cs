using nilnul.bit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.of_.unary_
{
	public abstract class OfExt4dblA :
		ext.of_.Unary4dblA
		
	{

		//[MethodImpl(MethodImplOptions.AggressiveInlining)]

		public abstract double _op_0ext(double par);

	

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override double op4dbl(Ext4dblI par)
		{
			return _op_0ext(par.errable);
		}
		

	}
}
