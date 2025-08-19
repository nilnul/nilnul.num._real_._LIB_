using System.Runtime.CompilerServices;

namespace nilnul.num.real
{
	public abstract class Bi8dblA :
		//nilnul.num.real.Op4dblI
		//,
		//nilnul.obj.op_._binary_.retParPar1_.ClosedI< R>
		//,
		//nilnul.obj.op_._binary_.par1_.retParPar1_.ClosedI<R>
		//,

		nilnul.obj.BiI<num.Real4dblI>
		,
		nilnul.num.real.Bi8dblI

	{
		public abstract double _op_01finite(double x, double y);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public double op4dbl(Real4dblI x, Real4dblI y)
		{
			return (_op_01finite(x.errable, y.errable));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Real4dblI op(in Real4dblI x, in Real4dblI y)
		{
			return new Real4dbl(op4dbl(x, y));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Real4dblI op( Real4dblI par,  Real4dblI par1)
		{
			return op(in par, in par1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public double op(in double par, in double par1)
		{
			return par + par1;
		}
	}


}
