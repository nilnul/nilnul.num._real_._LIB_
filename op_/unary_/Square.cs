using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.RealI;
namespace nilnul.num.real.op_.unary_
{
	public class Square
		: UnaryI
	{

		public R op(R arg)
		{

			return _SquareX.Op(arg);
		}



		public double op(double x)
		{
			return x * x;
		}


		public decimal op(decimal x)
		{
			return x * x;
		}

		static public Square Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}
		static private Lazy<Square> _Lazy = new Lazy<Square>();

		static public Square Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Square>.Instance;
			}
		}

	}
}