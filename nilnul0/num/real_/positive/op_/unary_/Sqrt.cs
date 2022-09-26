using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real_.positive.op_.unary_
{
	public class Sqrt
		: nilnul.num.real_.positive.op_.UnaryI
	{


		public const char CHAR = '\u221a';

		public PositiveI op(PositiveI arg)
		{
			return nonneg.op_.unary_._SqrtX.Positive(arg);
		}

		public PositiveI op(R arg)
		{
			return op(new nilnul.num.real_.Positive(arg));
		}

		//public R _op_assumePositive(nilnul.num.real_.Quotient arg)
		//{


		//	return real_.nonneg.op_.unary_.SqrtX.Sqrt(arg);
		//}

		public  R op(int v)
		{

			return op( new nilnul.num.real_.Quotient(v));
		}
		//public R _op_assumePositive(nilnul.num.Quotient1 arg)
		//{

		//	return _op_assumePositive(new Quotient(arg));
		//}

		//public R op(ulong arg)
		//{

		//	return op( new nilnul.num.real_.Quotient(arg));
		//}
		static public Sqrt Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sqrt>.Instance;
			}
		}


	}

	
}
