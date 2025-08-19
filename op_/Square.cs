using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.quotient_.DenomNonnil;//._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.RealI_onQuotient;
namespace nilnul.num.real.op_
{
	public class Square
		: real.OpI1
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

		public R0 op(in R0 obj)
		{
			return _SquareX.Op(in obj);
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