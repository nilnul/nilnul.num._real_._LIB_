using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op_.unary_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <see cref="nameof(nilnul.num.real_.nonneg.op_.unary_.Sqrt)"/>
	public  class Sqrt
		:
		num.real.op_.UnaryA_retRealOnRealI,
		nilnul.num.real.op_.UnaryI
		
	{

		public override nilnul.num.RealI op(nilnul.num.RealI arg)
		{
			return nilnul.num.real_.nonneg.op_.unary_.Sqrt.Singleton.op(arg);

		}

		static public Sqrt Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sqrt>.Instance;
			}
		}

		public RealI op(uint v)
		{
				return nilnul.num.real_.nonneg.op_.unary_._SqrtX.RetRealI(v);
		
		}

		
	}
}
