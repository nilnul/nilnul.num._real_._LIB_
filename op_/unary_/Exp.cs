using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using R = nilnul.num.RealI;
using Q1 = nilnul.num.Quotient1;
using R1 = nilnul.num.RealI;

namespace nilnul.num.real.op_.unary_
{
	/// <summary>
	/// raised to the GIVEN exponent of e, which is 2.71828183....
	/// </summary>
	/// <remarks>
	///		This is op_, not duo.op_, in that:
	///			1) it takes only one argument.
	///			2) the computation rules, with e as the base, are written in such a way that e is taken granted being fixed, and the logic is consequently simply and quite different from when the base is not e. In other words, the computation rule is ingrained by assuming e as the base first; postulating e is an integral part of the definitio of thi op_ 
	///		Mnemorics: exponential is e-x-pow.
	/// </remarks>
	public class Exp :
		UnaryA_retRealOnRealI,

		UnaryI
	{
		
		static public R1 RetRealI( Q1 q) {
			if (q<0)
			{
				return nilnul.num.real_.nonnil.op_.unary_._InverseX.Op(
					new _exp.ret_.ofQuotient_.OfPositive(-q)
				);
			}
			if (q==0)
			{
				return nilnul.num.real_.Quotient.CreateOne();
			}
			if (q==1)
			{
				return  nilnul.num.real_.Euler.Singleton;

			}

			return new _exp.ret_.ofQuotient_.OfPositive(q);

		}
		static public Real RetReal(Q1 q) {
			return new Real(RetRealI(q));
			}

		static public R1 RetRealI_ofMayIrrational(R1 x) {
			

			return new _exp.Ret(x);
		}


		static public R1 RetRealI(R1 x) {
			if (nilnul.num.real.be_.Quotient.Singleton.be(x) )
			{
				return RetRealI(x.current.lower.mark);
			}

			return RetRealI_ofMayIrrational(x);
		}


		public override R1 op(R1 arg)
		{
			return RetRealI(arg);
			//throw new NotImplementedException();
		}


		public R1 op(nilnul.num.Real arg)
		{
			return RetRealI(arg);
			//throw new NotImplementedException();
		}


		public R1 op(int arg)
		{
			return RetRealI(arg);
			//throw new NotImplementedException();
		}



		static public Exp Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Exp>.Instance;
			}
		}







	}
}
