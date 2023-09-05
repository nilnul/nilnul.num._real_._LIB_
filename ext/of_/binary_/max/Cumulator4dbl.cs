using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.op_.binary_.max
{
	public class Cumulator4dbl
		: nilnul.obj.op_.binary.cumulator_.OpDefault<double, Min>
,
		nilnul.obj.op_.binary.CumulatorI<double>
		,
		nilnul.obj.op_.binary.cumulator_.IUnardable
		//,
		//nilnul.obj.op_.binary_.commutative.CumulatorI<double>
	{
		public Cumulator4dbl() : base(
			
			double.NegativeInfinity//  we need <see cref="nilnul.obj.op_.binary.cumulator.be_.UnardableI{T}"/>, not <see cref="nilnul.obj.op_.binary.cumulator.be_.INardable"/>;
		)
		{
		}


		static public Cumulator4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cumulator4dbl>.Instance;
			}
		}

	}
}
