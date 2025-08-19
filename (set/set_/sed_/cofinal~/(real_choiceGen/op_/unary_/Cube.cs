using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;


namespace nilnul.num.real.op_
{
	public class Cube
		: nilnul.num.real.OpI2
	{

		static public readonly Cube Singleton = SingletonByDefault<Cube>.Instance;

		public R eval(R arg)
		{
			return new _cube.Call(arg);
			throw new NotImplementedException();
		}

		public double eval(double x) {
			return x * x * x;
		}
	}
}
