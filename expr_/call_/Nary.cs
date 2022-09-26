using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.op_;
using nilnul.num.real.var;
using R = nilnul.num.RealI;
using V = nilnul.num.real.VarI;


namespace nilnul.num.real.expr_.call_
{
	public class Nary1
		:
		nilnul.obj.expr_.typed_.generi_.call_.Nary< R>
		,
		nilnul.num.real.expr_.CallI1

	{
		public Nary1(R arg) : base(
			(arg)
		)
		{
		}




		public Nary1(NumI1 y):this(
			new nilnul.num.real_.Quotient(y)
		)
		{
		}

		public nilnul.num.real.var.Set vars
		{
			get
			{
				return new var.Set();

				//throw new NotImplementedException();
			}
		}

		

	
	}
}
