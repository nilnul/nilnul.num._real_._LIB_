using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Q1 = nilnul.num.Quotient1;

using R = nilnul.num.RealI; 

namespace nilnul.num.real.op_.unary_
{
	/// <summary>
	/// sin(x) / cos(x)
	/// </summary>
	static public class _TgX
	{
		static public R RealI(R x) {
			return real.co_.divisible._DivX.Bind(
				_Sin_byClampArgX.RetRealI(x)
				,
				_Cos_byClampArgX.RealI(x) 
			);
		}
	}

	public class Tg : UnaryI
	{
		public R op(R par)
		{
			return _TgX.RealI(par);
			;
		}


		static public Tg Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Tg>.Instance;
			}
		}

	}

}
