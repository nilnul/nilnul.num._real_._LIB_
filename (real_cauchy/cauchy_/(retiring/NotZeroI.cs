using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach_;

namespace nilnul.num._real.approach.generator_
{
	public interface NotZeroI:GeneratorI
	{

		approach_.NotZeroI generate();

	}


	public class NotZero
	:
	nilnul._call.ArgA<GeneratorI>
	,
		NotZeroI
		,

	GeneratorI
	{
		private approach_.NotZero _approach;

		public approach_.NotZero approach
		{
			get { return _approach; }
			set { _approach = value; }
		}

		public NotZero(GeneratorI val) : base(val)
		{
			_approach = new _real.approach_.NotZero(val.generate());
		}

		public ApproachI1 generate()
		{
			return _approach;
			throw new NotImplementedException();
		}

		approach_.NotZeroI NotZeroI.generate()
		{
			return _approach;

			throw new NotImplementedException();
		}
	}

}
