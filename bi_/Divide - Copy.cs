
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI_onQuotient;


using System.Numerics;
using nilnul.num.real_;

namespace nilnul.num.real.of_.binary_
{
	public class Divide
		:

		nilnul.num.real.of_.BinaryI

	{
		public const char Sign = '/';

		public R op(R a, R b)
		{

			return nilnul.num.real.co_.divisible._DivX.Bind(a,  b);
		}

		public R op(R a, nilnul.num.quotient_.DenomNonnil b)
		{
			return nilnul.num.real.op_._ScaleX.Op(a, b.toInverse());

		}

		public R op(R a, nilnul.num.real_.Quotient_denomNonnil b)
		{
			return op(a, b.boxed);

		}



		public override string ToString()
		{
			return Sign.ToString();
		}

		public R op(nilnul.num.quotient_.DenomNonnil a, RealI_onQuotient b)
		{
			return nilnul.num.real.op_._ScaleX.Op(  nilnul.num.real_.nonnil.op_._InverseX.Op(b),a);
		}
		public R op(nilnul.num.real_. Quotient_denomNonnil a, RealI_onQuotient b)
		{
			return op( a.boxed,b);
		}
		public R op(nilnul.num.real_. Quotient_denomNonnil a, Real_onQuotient b)
		{
			return op(
				a,
				(RealI_onQuotient)b
			);//.Lazy.op(;
		}


		public R op(int a, R b)
		{
			return op(
				(nilnul.num.real_.Quotient_denomNonnil)a
				,b
			);
			//throw new NotImplementedException();
		}


	

		public  R op(R x, BigInteger b)
		{
			return nilnul.num.real.op_._ScaleX.Op(
				x
				,
				nilnul.num.quotient_.DenomNonnil.Inverse(b)
				
			);
		}

	

		static public Divide Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Divide>.Instance;
			}
		}
	}
}
