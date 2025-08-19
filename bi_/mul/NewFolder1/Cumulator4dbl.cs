using nilnul.obj.of_.binary._cumulator_;
using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.binary_.multi
{
	public class Cumulator4dbl:
		nilnul.obj.op_.binary.Accumulator_opDefault<double, Multi4dbl>
		,
		nilnul.num.real.of_.binary.Cumulator4dblI

	{
		public Cumulator4dbl() : base(1)
		{
		}

		static public Cumulator4dbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Cumulator4dbl>.Instance;
			}
		}


		BinaryI<double> obj.bi._cumula_.BinderI<BinaryI<double>>.binder => binder;
	}
}
