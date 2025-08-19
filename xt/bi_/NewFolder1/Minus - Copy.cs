using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.op_.binary_
{
	public class Minus :
		nilnul.num.real.ext.of_.binary_.EachAssumeExtA 
		,
		real.ext.op_.BinaryI
		,
		nilnul.num.real.ext.of_.Binary4dblI
	{

		public override double _op_01ext(double a, double b)
		{
			if (double.IsPositiveInfinity(a) )
			{
				if (double.IsPositiveInfinity(b) )
				{
					return 0;
				}
			}
			if (double.IsNegativeInfinity(a) )
			{
				if (double.IsNegativeInfinity(b))
				{
					return 0;
				}
			}
			return a - b;
		}



		public ExtI op(ExtI par,ExtI par1)
		{
			return Add.Singleton.op(
				par
				,
				op_.unary_.Neg.Singleton.op(par1)
			);

		}


		static public Minus Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Minus>.Instance;
			}
		}

	}
}
