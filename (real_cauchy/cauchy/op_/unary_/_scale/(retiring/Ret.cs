using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num._real.approach.generator.op_._scale
{


	public class Ret : Arg
		,
		GeneratorI
	{
		private Q _scale;

		public Q scale
		{
			get { return _scale; }
			set { _scale = value; }
		}

		public Ret(GeneratorI arg, Q scale ) : base(arg)
		{
			_scale = scale;
		}

		public ApproachI1 generate()
		{
			return  nilnul.num._real.approach.op_._ScaleX.Scale( arg.generate(), _scale);
			//todo
			//throw new NotImplementedException();
		}


	

	}
}
