using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.var;

namespace nilnul.num.real
{
	public interface FuncI2
		:
		nilnul.num.real._func_.ParsI
		,
		nilnul.num.real._func_.BodyI
	{
	}


	public class Func2 
		:
		_func_.ParsA
		,
		FuncI2
	{
		private nilnul.num.real.ExprI _body;

		public nilnul.num.real.ExprI body
		{
			get { return _body; }
			set { _body = value; }
		}

		public Func2(Sortie pars, nilnul.num.real.ExprI body) : base(pars)
		{
			_body = body;
		}


	}
}
