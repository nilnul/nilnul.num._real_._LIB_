
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


using System.Numerics;

namespace nilnul.num.real.op_.binary_
{
	public class Divide
		: BinaryI
	{
		public const char Sign = '/';

		public R op(R a, R b)
		{

			return nilnul.num.real.co_.divisible._DivX.Bind(a, ( b));
		}

		public R op(R a, nilnul.num.real_.Quotient b)
		{
			return nilnul.num.real.co_.divisible._DivX.Bind(a, b);

		}


		public override string ToString()
		{
			return Sign.ToString();
		}
		public R op(nilnul.num.real_. Quotient a, Real b)
		{
			return real.co_.divisible._DivX.Bind(
				a,
				b
			);//.Lazy.op(;
		}
		public R op(nilnul.num.real_. Quotient a, R b)
		{
			return nilnul.num.real.co_.divisible._DivX.Bind(
				a,
				(b)
			);//.Lazy.op(;
		}

		public R op(int a, R b)
		{
			return nilnul.num.real.co_.divisible._DivX.Bind(
				a
				,b
			);
			//throw new NotImplementedException();
		}


		public R op(Quotient1 a, Real b)
		{
			return co_.divisible._DivX.Bind(
				a,
				b
			);//.Lazy.op(;
		}
		public R op(Quotient1 a, R b)
		{
			return nilnul.num.real.co_.divisible._DivX.Bind(
				a,
				b
			);//.Lazy.op(;
		}

		public  R op(R x, BigInteger b)
		{
			return nilnul.num.real.co_.divisible._DivX.Bind(
				x, b);
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
