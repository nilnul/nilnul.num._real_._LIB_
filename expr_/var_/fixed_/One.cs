using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.var_.fixed_
{
	/// <summary>
	/// can be used in <see cref="expr_._algebraic."/> to make the expr theoretically beautiful while practically little use as the special case can be treated specially quite trivia.
	/// </summary>
	public class One
	:
		expr_.Var1
		,
	nilnul.num.real.expr_.var_.FixedI
	{
		private static readonly One _instance = new One();

		private One():base("1")
		{
		}

		public static One Instance
		{
			get { return _instance; }
		}
	}
	
}
