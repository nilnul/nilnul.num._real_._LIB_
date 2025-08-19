using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CofinalI = nilnul.num.RealI2;
using R1 = nilnul.num.RealI2;
using Quotient2 = nilnul.num.real_.Quotient;

namespace nilnul.num.real.duo.op_
{
	public class Pow
		: OpI
	{
		public const char Sign = '*';


		static public readonly Pow Singleton = SingletonByDefault<Pow>.Instance;


		public CofinalI eval(CofinalI a, CofinalI b)
		{
			return new _ret.Pow(a, b);

		}

		public CofinalI eval(int  a, CofinalI b)
		{
			return eval( new Quotient2(a),b );

		}

		public override string ToString()
		{
			return Sign.ToString();
		}

	}

	
}
