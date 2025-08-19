using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.binary_
{
	public interface PowI: nilnul.num.real.op_.BinaryI2
	{
	}

	public class Pow : PowI
	{

		public num.RealI6 op(num.RealI6 arg, num.RealI6 arg1)
		{
			throw new NotImplementedException();
		}

		static public Pow Singleton
		{
			get
			{
				return nilnul.Singleton1<Pow>.Instance;
			}
		}

	}
}
