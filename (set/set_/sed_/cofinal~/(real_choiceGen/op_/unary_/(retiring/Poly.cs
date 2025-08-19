using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;

using N = nilnul._num.bigint.be.Natural.Asserted;


namespace nilnul.num.real.op_
{
	public class Poly
		
	{

		static public readonly Poly Singleton = SingletonByDefault<Poly>.Instance;

		public R eval(R arg, N index)
		{
			if (arg is nilnul.num.real_.Quotient)
			{
				return nilnul.num.real_.quotient.convert_.Poly.Eval(arg as nilnul.num.real_.Quotient, index);
			}
			return new _poly.Ret(arg, index);

		//	throw new NotImplementedException();
		}


	}
}
