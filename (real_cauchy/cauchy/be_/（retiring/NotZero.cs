using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach.generator.be_
{
	public class NotZero : BeI
	{

		static public readonly NotZero Singleton = SingletonByDefault<NotZero>.Instance;

		public bool be(GeneratorI obj)
		{
			return _real.approach.be_.Nonzero.Singleton.be(obj.generate());

			//throw new NotImplementedException();
		}

		public class En 
			:
			nilnul._call.ArgA<GeneratorI>
			,
			
			GeneratorI
		{
			private approach.be_.Nonzero.En _approach;

			public approach.be_.Nonzero.En approach
			{
				get { return _approach; }
				set { _approach = value; }
			}

			public En(GeneratorI val) : base(val)
			{
				_approach = 		new _real.approach.be_.Nonzero.En(val.generate());
			}

			public ApproachI1 generate()
			{
				return _approach;
				throw new NotImplementedException();
			}
		}
	}

}
