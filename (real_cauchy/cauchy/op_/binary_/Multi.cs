using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.num._real.cauchy.op_.binary_
{
	public class Multi
		:BinaryI
	{
		public const char Sign = '*';

		

		public CauchyI2 op(CauchyI2 par, CauchyI2 par1)
		{
			return new _multi.Ret(par, par1);
			//throw new NotImplementedException();
		}

		static public Multi Singleton
		{
			get
			{
				return nilnul.Singleton1<Multi>.Instance;
			}
		}

	}
}
