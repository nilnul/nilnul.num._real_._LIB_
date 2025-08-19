using System;

namespace nilnul.num.real.of_
{
	[Obsolete()]
	public abstract class Binary4dblA :
		//nilnul.num.real.Op4dblI
		//,
		//nilnul.obj.op_._binary_.retParPar1_.ClosedI< R>
		//,
		//nilnul.obj.op_._binary_.par1_.retParPar1_.ClosedI<R>
		//,

		nilnul.obj.of_.BinaryI<num.Real4dblI>

	{
		public abstract double _op_01finite(double x, double y);
		public double op4dbl(Real4dblI x, Real4dblI y)
		{
			return (_op_01finite(x.errable, y.errable));
		}

		public Real4dblI op(Real4dblI x, Real4dblI y)
		{
			return new Real4dbl(op4dbl(x, y));
		}


	}


}
