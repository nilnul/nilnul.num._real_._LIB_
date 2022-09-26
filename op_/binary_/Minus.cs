
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


using System.Numerics;

namespace nilnul.num.real.op_.binary_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		subtraction
	public class Minus
		: BinaryI
	{
		public const char Sign = '-';

		public R op(R a, R b)
		{
			if (object.ReferenceEquals(a,b))
			{
				return new nilnul.num.Real( );
			}


			return Add.Singleton.op(a, op_.unary_.Neg.Singleton.op(b));
		}

		public R op(R a, nilnul.num.real_.Quotient b)
		{
			return real.op_.unary_._ShiftX.Op(-(b), a );

		}


		public override string ToString()
		{
			return Sign.ToString();
		}

		public R op(int v, R val)
		{
			return op(
				(nilnul.num.real_.Quotient)v,val
			);
			//throw new NotImplementedException();
		}

		public R op(nilnul.num.real_. Quotient quotient1, Real realI)
		{
			return op_.binary_.Add.Op(
				quotient1,
				-realI
			);//.Lazy.op(;
		}
		public R op(nilnul.num.real_. Quotient quotient1, R realI)
		{
			return op(
				quotient1,
				new Real(realI)
			);//.Lazy.op(;
		}

		public R op(Quotient1 quotient1, Real realI)
		{
			return op_.binary_.Add.Singleton.op(
				quotient1,
				-realI
			);//.Lazy.op(;
		}
		public R op(Quotient1 quotient1, R realI)
		{
			return op(
				quotient1,
				new Real(realI)
			);//.Lazy.op(;
		}

		public  R op(R result, BigInteger floor)
		{
			return op(result, new nilnul.num.real_.Quotient(floor));
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
