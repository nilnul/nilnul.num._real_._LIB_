using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.convert_
{
	

	public class Square
		:ConvertI
	{
		static public double Eval(double x) {
			return x * x;
		}
		static public decimal Eval(decimal x) {
			return x * x;
		}



		public num.RealI2 eval(num.RealI2 arg)
		{
			return nilnul.num.real.duo.op_.Multi.Singleton.eval(arg,arg);

			//throw new NotImplementedException();
		}


		static public readonly Square Singleton = nilnul.obj.SingletonByDefault<Square>.Instance;

	}
}
