using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.approach.generator.duo.be_
{
	/// <summary>
	/// if one of them is nil
	/// </summary>
	public class EitherNil : BeI
	{
		public bool be(Duo obj)
		{
			return be(obj.Item1,obj.Item2);

			throw new NotImplementedException();
		}
		public bool be(GeneratorI x, GeneratorI y) {
			return nilnul.num._real.approach.duo.be_.EitherNil.Singleton.be(x.generate(), y.generate());
		}


		static public EitherNil Singleton
		{
			get
			{
				return nilnul._obj.Singleton<EitherNil>.Instance;
			}
		}

	}
}
