using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach_;

namespace nilnul.num._real.approach.generator_
{
	public interface NonNegI:GeneratorI
	{

		approach_.NonNegI generate();

	}


	public class NonNeg
	:
	nilnul._call.ArgA<GeneratorI>
	,
		NonNegI
		,

	GeneratorI
	{
		private approach_.NonNeg _approach;

		public approach_.NonNeg approach
		{
			get { return _approach; }
			set { _approach = value; }
		}

		public NonNeg(GeneratorI val) : base(val)
		{
			_approach = new _real.approach_.NonNeg(val.generate());
		}

		public ApproachI1 generate()
		{
			return _approach;
			throw new NotImplementedException();
		}

		approach_.NonNegI NonNegI.generate()
		{
			return _approach;

			//throw new NotImplementedException();
		}
	}

}
