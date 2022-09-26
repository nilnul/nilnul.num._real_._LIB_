using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_
{
	public interface IUnary { }
	public interface UnaryI
		:
		nilnul.num.real.OpI
		,
		nilnul.obj.op_._unary_.retPar_.ClosedI<nilnul.num.RealI>
		,IUnary
	{

	}

	public abstract class UnaryA_retRealOnRealI : UnaryI
	{
		public abstract RealI op(RealI par);
		public Real op_retReal(RealI par)
		{
			return
				new Real(op(par))
			;
		}
		public Real op_retReal(Real par)
		{
			return
				UnaryX.RetReal(this,par);
			;
		}


	}



	public abstract class UnaryA : UnaryI
		,
		_unary_.OfClass
	{
		public RealI op(RealI par)
		{
			return
				op(new Real(par))
			;
		}
		public abstract Real op(Real x);



	}

	static public class UnaryX
	{
		static public RealI Op(this UnaryI op, nilnul.num.Quotient1 quotient)
		{
			return op.op(new nilnul.num.Real(quotient));
		}

		static public Real RetReal(this nilnul.num.real.op_.UnaryI op, nilnul.num.RealI arg)
		{
			return new Real(op.op(arg));
		}
	}
}
