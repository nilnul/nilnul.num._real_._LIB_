using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach.generator.be_
{
	public class NonNeg : BeI
	{

		static public readonly NonNeg Singleton = SingletonByDefault<NonNeg>.Instance;

		public bool be(GeneratorI obj)
		{
			return _real.approach.be_.Nonneg.Singleton.be(obj.generate());

			//throw new NotImplementedException();
		}

		public class En 
			:
			nilnul._call.ArgA<GeneratorI>
			,
			
			GeneratorI
		{
			private approach.be_.Nonneg.En _approach;

			public approach.be_.Nonneg.En approach
			{
				get { return _approach; }
				set { _approach = value; }
			}

			public En(GeneratorI val) : base(val)
			{
				_approach = 		new _real.approach.be_.Nonneg.En(val.generate());
			}

			public ApproachI1 generate()
			{
				return _approach;
			//	throw new NotImplementedException();
			}
		}
	}

}
