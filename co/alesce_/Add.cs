using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.co.alesce_
{
	public class Add :
		nilnul.num.real.op_.Binary4dblI
		,
		co.Alesce4floatI
	{
		public double op(double par, double par1)
		{
			return par + par1;
			throw new NotImplementedException();
		}

		public float op(float par, float par1)
		{
			return par + par1;
			throw new NotImplementedException();
		}

		static public Add Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Add>.Instance;
			}
		}

	}
}
