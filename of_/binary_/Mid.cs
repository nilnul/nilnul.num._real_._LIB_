using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using r = nilnul.num.rational;
using q = nilnul.num.quotient;
using R = nilnul.num.RealI;//.real.RealI_posConverge2NonEmpty;
using A = nilnul.num.RealI;
using R1 = nilnul.num.RealI;

using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num.quotient.border.duo.be_;
using Q0 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;

namespace nilnul.num.real.of_.binary_
{
	public  class Mid
		:
		of_.Binary4dblA
		,
		op_.BinaryI
		,
		real.of_.Binary4dblI
	{



		public R1 op(R1 a, R1 b)
		{
			return Add.Singleton.op(a, b).ToImpl() /2;
		}
	

		public double op(double par, double par1)
		{
			return _op_01finite(par,par1);
		}

		public override double _op_01finite(double x, double y)
		{
			return x + y;
			//throw new NotImplementedException();
		}

		static public Mid Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Mid>.Instance;
			}
		}



	}
}
