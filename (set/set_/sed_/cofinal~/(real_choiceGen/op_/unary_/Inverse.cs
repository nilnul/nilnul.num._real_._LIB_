using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;


namespace nilnul.num.real.op_.unary_
{
	/// <summary>
	/// 
	/// </summary>
	/// <see cref="nameof(nilnul.num.real_.nonnil.op_.unary_._InverseX)"/>
	static public class _InverseX
	{

		static public double Op(double x) {
			return 1 / x;

		}

	}

	public class Inverse : UnaryI2
	{
		public RealI6 op(RealI6 par)
		{
			//make it nonnil
			if (nilnul.num.real.be_.Nil2.Singleton.be(par))
			{
				throw new DivideByZeroException();
			}
			return nilnul.num.real_.nonnil.op_.unary_._InverseX1.Op(par);
		}


		static public Inverse Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Inverse>.Instance;
			}
		}

	}
}
