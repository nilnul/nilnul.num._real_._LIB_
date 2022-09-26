using nilnul.num.real.expr_._algebraic.pows.prod.scaleds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.op_.binary_.multi
{
	public class Cumulator
		:
		nilnul.obj.op_.binary.cumulator_.OpDefault<
			Algebraic
			,
			Multi
		>
	{
		public Cumulator() : base(new Algebraic(1))
		{
		}

		static public Cumulator Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cumulator>.Instance;
			}
		}

	}
}
