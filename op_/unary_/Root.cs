using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num_;

namespace nilnul.num.real.op_.unary_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _RootX
	{

		static public nilnul.num.RealI RetRealI(nilnul.num.Real x, nilnul.num_.Positive1 index)
		{
			if (index.en % 2 == 0)
			{
				return nilnul.num.real_.nonneg.op_.unary_._RootX.RetNonnegI(new real_.Nonneg(x), index);

			}
			if (nilnul.num.real.be_.Negative.Singleton.be(x))
			{

				return -nilnul.num.real_.positive.op_.unary_._RootX.RetPositive(new real_.Positive(-x), index);

			}
			return nilnul.num.real_.nonneg.op_.unary_._RootX.RetRealI(x, index);

		}


		static public nilnul.num.RealI RetRealI(nilnul.num.RealI x, nilnul.num_.Positive1 index)
		{
			return RetRealI(new Real(x), index);
		}
		static public nilnul.num.RealI RetRealI(nilnul.num.RealI v1, int v2)
		{
			return RetRealI(v1,new Positive1(v2));
		}

	}

	public class Root :
		nilnul.obj.Box<nilnul.num_.Positive1>
		,
		num.real.op_.UnaryI
		,
		_unary_.RetRealOnRealI
	{
		public Root(Positive1 val) : base(val)
		{
		}

		public Root(Num1 poly) : this(new Positive1(poly))
		{
		}

		public RealI op(RealI par)
		{
			return nilnul.num.real_.nonneg.op_.unary_._RootX.RetRealI(par, boxed);
		}

		public Real op_retReal(RealI par)
		{
			return UnaryX.RetReal(this, par);
		}
	}
}
