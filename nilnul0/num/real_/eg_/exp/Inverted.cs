using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.euler
{
	static public class _InvertedX
	{

		static public nilnul.num.RealI Call() {
			return nilnul.num.real_.nonnil.op_.unary_._InverseX.Op(
				nilnul.num.real_.Euler.Singleton
			);
		}

		static public nilnul.num.RealI Cached = Call();

	}
}
