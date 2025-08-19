using nilnul.bit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.of_
{
	public abstract class Unary4dblA :

		num.real.ext.of_.Unary4dblI
	{



		//[MethodImpl(MethodImplOptions.AggressiveInlining)]

		public abstract double op4dbl(Ext4dblI par);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Ext4dbl op4impl(Ext4dblI par)
		{
			return new Ext4dbl(op4dbl(par));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Ext4dblI op(Ext4dblI par)
		{
			return op4impl(par);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Ext4dblI op(double x)
		{
			return op4impl(new real.Ext4dbl(x));
		}

	}
}
