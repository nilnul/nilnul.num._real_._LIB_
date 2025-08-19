using nilnul.bit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.of_
{
	public abstract class Binary4dblA :

		num.real.ext.of_.Binary4dblI
	{



		//[MethodImpl(MethodImplOptions.AggressiveInlining)]

		public abstract double op4dbl(Ext4dblI par, Ext4dblI par1);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Ext4dbl op4impl(Ext4dblI par, Ext4dblI par1)
		{
			return new Ext4dbl(op4dbl(par,par1));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Ext4dblI op(Ext4dblI par,Ext4dblI par1)
		{
			return op4impl(par,par1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Ext4dblI op(double x,double y)
		{
			return op4impl(new real.Ext4dbl(x) ,new real.Ext4dbl(y)  );
		}

	}
}
