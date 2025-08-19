using nilnul.num._real.limit.sow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num._real.approach._sow;
using nilnul.num._real.approach;

namespace nilnul.num.real_
{
	public class FroGenerator: RealI2
	{
		private _real.approach.GeneratorI _generator;

		public GeneratorI generator
		{
			get { return _generator; }
			set { _generator = value; }
		}

		public FroGenerator(GeneratorI generator)
		{
			_generator = generator;

		}



	

		public GeneratorI choice
		{
			get
			{
				return _generator;
				//throw new NotImplementedException();
			}
		}


	}

	
}
