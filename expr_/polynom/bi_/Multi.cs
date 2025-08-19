using nilnul.num.real.expr_._algebraic.pows.prod.scaleds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.op_.binary_
{
	public class Multi :
		BinaryI
	{
		public Algebraic op(Algebraic par, Algebraic par1)
		{
			return par * par1;
			//throw new NotImplementedException();
		}


		static public Multi Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Multi>.Instance;
			}
		}

	}
}
