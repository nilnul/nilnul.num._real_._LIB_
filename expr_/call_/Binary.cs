﻿using System;
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
	public class Binary
		:
		nilnul.obj._call_.OpA1< 
			nilnul.num.real.op_.BinaryI
		>
		,
		_call_.ArgArg1I
		,
		nilnul.num.real.expr_.CallI
	{
		public Binary(nilnul.num.real.op_.BinaryI op, PlainI arg,PlainI arg1) : base(
			op
		)
		{
			_arg = arg;
		}

		public Binary(nilnul.num.real.op_.BinaryI op, ExprI arg,ExprI arg1) : base(
			op
		)
		{
			_arg = arg;
		}


		
		public Binary(nilnul.num.real.op_.BinaryI op, nilnul.num.real.VarI arg,PlainI arg1) : this(
			op
			,
			new nilnul.num.real.expr_.Var(arg)
			,
			arg1
		)
		{
			
		}
		public Binary(nilnul.num.real.op_.BinaryI op,PlainI arg, nilnul.num.real.VarI arg1) : this(
			op
			,
			arg
			,
			new nilnul.num.real.expr_.Var(arg1)
		)
		{
			
		}

		public Binary(nilnul.num.real.op_.BinaryI op, nilnul.num.real.VarI arg,nilnul.num.real.VarI arg1) : this(
			op
			,
			arg
			,
			new nilnul.num.real.expr_.Var(arg1)
		)
		{
			
		}



		public nilnul.num.real.var.Set vars
		{
			get
			{
				return nilnul.num.real.var.set.op_.binary_._UnionX.Union(arg.vars,arg1.vars);

				//throw new NotImplementedException();
			}
		}

		private ExprI _arg;
		public ExprI arg => _arg;

		private ExprI _arg1;
		public ExprI arg1 => _arg1;

		public nilnul.num.real.ExprI substitute(nilnul.num.real.VarI var, nilnul.num.real.ExprI expr)
		{
			return new Binary(this.op
				,
				this.arg.substitute(var, expr)
				,
				this.arg1.substitute(var,expr)
			);
			//throw new NotImplementedException();
		}


	}
}
