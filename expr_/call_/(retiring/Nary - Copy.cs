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
	public class Nary
		:
		nilnul.obj._call_.OpA1< 
			nilnul.num.real.ConstantI
		>
		,
		nilnul.num.real.expr_.CallI
	{
		public Nary(R arg) : this(
			new nilnul.num.real.Constant(arg)
		)
		{
		}



		public Nary(ConstantI op) : base(op)
		{
		}

		public Nary(NumI1 y):this(
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

		

	
		public ExprI substitute(V var, ExprI expr)
		{
			return this;
		}
	}
}
