
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;
using Rq = nilnul.num.real_.Quotient;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;


namespace nilnul.num.real.op_.binary_
{
	static public class _MultiX
	{

		static public R Op(R a, R b)
		{
			if (object.ReferenceEquals(a,b) )		//to maximize the reuse of the converging process
			{
				return nilnul.num.real.op_.unary_._SquareX.Op(a);
			}

			if (nilnul.num.real.be_.Quotient.Singleton.be(a))
			{
				return nilnul.num.real.op_.unary_._ScaleX.Op(a.current.lower.mark, b);
			}
			if (nilnul.num.real.be_.Quotient.Singleton.be(b) )
			{
				return nilnul.num.real.op_.unary_._ScaleX.Op(b.current.lower.mark, a);

			}

			//if (object.ReferenceEquals(a,b) )		//to maximize the reuse of the converging process
			//{
			//	return nilnul.num.real.op_.unary_._SquareX.Op_assumeNotQuotient(a);
			//}
			return new _multi.Ret(a, b);
			//throw new NotImplementedException();
		}

	}
	public class Multi
		: op_.BinaryI
	{
		public const char Sign = '*';

		public R op(R a, R b)
		{
			return _MultiX.Op(a, b);

			//if (a is nilnul.num.real_.Quotient aAsQ)
			//{
			//	//var aAsQ = (Qr)a;
			//	if (b is nilnul.num.real_.Quotient bAsQ)
			//	{
			//		//var bAsQ = (Qr)b;
			//		return new Qr( aAsQ.boxed* bAsQ.boxed);
			//	}
			//	return nilnul.num.real.op_.unary_._ScaleX.Scale(aAsQ, b);
			//}
			//return new _multi.Ret(a, b);
			////throw new NotImplementedException();
		}

		public R op(int  a, R b)
		{
			return  op_.unary_._ScaleX.Op((a),b );
		}

		public override string ToString()
		{
			return Sign.ToString();
		}

		static public Multi Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Multi>.Instance;
			}
		}
	}
}
