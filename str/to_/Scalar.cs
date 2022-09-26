using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.str.to_
{
	public interface ScalarI
		:nilnul.obj.str.to_.ScalarI<R>

	{
	}

	public interface Scalar4dblI
		:nilnul.obj.str.to_.ScalarI<double>

	{
	//	double toScalar(IEnumerable<double> str);
	}
	public abstract class ScalarA : ScalarI
		,
		_scalar_.OfParams4RealI
	{

		public abstract R op(IEnumerable<R> par);

		public R op(params R[] dbls)
		{
			return op((IEnumerable<R>)dbls);
			//throw new NotImplementedException();
		}

		public R to(IEnumerable<R> src)
		{
			return op(src);
		}
	}

	public abstract class Scalar4dblA : Scalar4dblI
		,
		_scalar_.OfParamsI
	{

		public abstract double op(IEnumerable<double> par);

		public double op(params double[] dbls)
		{
			return op((IEnumerable<double>)dbls);
			//throw new NotImplementedException();
		}

		public double to(IEnumerable<double> src)
		{
			return op(src);

		}
	}
}
