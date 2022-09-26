using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.var;

namespace nilnul.num.real.expr_.call_
{
	[Obsolete()]

	public class Ni
		: nilnul.obj.expr_.call_.Ni<nilnul.num.RealI2>
		,
		nilnul.num.real.ExprI1
	{
		public Ni(num.RealI2 arg) : base(arg)
		{
		}

		public Set1 vars
		{
			get
			{
				return new Set1();

				throw new NotImplementedException();
			}
		}

		public ExprI1 reduce()
		{
			return this;
			throw new NotImplementedException();
		}

		public ExprI1 substitute(VarI var, ExprI1 expr)
		{
			return this;
			throw new NotImplementedException();
		}


		public static ExprI1 CreateSin(ExprI1 x)
		{

			return new Uni(
				nilnul.num.real.op_.Sin.Singleton,

				 x



			);

			//throw new NotImplementedException();
		}
	}
}
