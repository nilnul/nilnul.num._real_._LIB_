using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach_;

namespace nilnul.num._real.approach.generator_
{
	public interface PositiveI:GeneratorI
	{

		approach_.PositiveI generate();

	}


	public class Positive
	:
	nilnul._call.ArgA<GeneratorI>
	,
		PositiveI
		,

	GeneratorI
	{
		private approach_.PositiveI _approach;

		public approach_.PositiveI approach
		{
			get { return _approach; }
			set { _approach = value; }
		}

		public Positive(GeneratorI val) : base(val)
		{
			_approach = new _real.approach_.Positive(val.generate());
		}

		public ApproachI1 generate()
		{
			return _approach;
			throw new NotImplementedException();
		}

		approach_.PositiveI PositiveI.generate()
		{
			return _approach;

			//throw new NotImplementedException();
		}
	}

}
