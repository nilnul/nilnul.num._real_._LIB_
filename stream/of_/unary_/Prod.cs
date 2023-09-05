using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.op_.unary_
{
	/// <summary>
	/// accumulate the initial terms by product of them, to get a new stream of products
	/// </summary>
	public class Prod :UnaryI
	{

		public StreamI op(StreamI par)
		{
			return new _prod.Ret(par);
		}


		static public Prod Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Prod>.Instance;
			}
		}

	}
}
