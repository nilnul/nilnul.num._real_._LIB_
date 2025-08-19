using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.op_.unary_
{
	public class Invert : real.ext.op_.UnaryI
	{
		public ExtI op(ExtI par)
		{
			switch (par)
			{
				case ext_.InfI neg:
					return new ext_.Bare(0);

				default:
					return new ext_.Bare( nilnul.num.real_.nonnil.op_.unary_._InverseX.Op( ( (ext_.Bare)par).val ) );

					break;
			}
			//throw new NotImplementedException();
		}

		static public Invert Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Invert>.Instance;
			}
		}

	}
}
