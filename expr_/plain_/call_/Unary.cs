using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.op_;
using nilnul.num.real.var;
using R = nilnul.num.RealI;
using V = nilnul.num.real.VarI;


namespace nilnul.num.real.expr_.plain_.call_
{
	public class Unary
		:
		nilnul.obj._call_.OpA1< 
			nilnul.num.real.op_.UnaryI
		>
		,
		_call_.ArgI
		,
		nilnul.num.real.expr_.plain_.CallI
	{
		public Unary(nilnul.num.real.op_.UnaryI op, PlainI arg) : base(
			op
			
		)
		{

			_arg = arg;
		}

		
		public Unary(nilnul.num.real.op_.UnaryI op, nilnul.num.real.VarI arg) : this(
			op
			,
			new nilnul.num.real.expr_.Var(arg)
			
		)
		{
		}

		

		public nilnul.num.real.var.Set vars
		{
			get
			{
				return arg.vars;

				//throw new NotImplementedException();
			}
		}

		private PlainI _arg;

		public PlainI arg => _arg;

		public nilnul.num.real.expr_.PlainI substitute(nilnul.num.real.VarI var, nilnul.num.real.expr_.PlainI expr)
		{
			return new Unary(op, arg.substitute(var,expr));
			//throw new NotImplementedException();
		}

		public ExprI substitute(V var, ExprI expr)
		{

			return new expr_.call_.Unary(op, arg.substitute(var,expr));
			;
		}
	}
}
