using nilnul.num.real.expr_._algebraic.pows.prod.scaleds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.op_.binary_
{
	public class Add :
		BinaryI
	{
		public Algebraic op(Algebraic par, Algebraic par1)
		{
			return par + par1;
			//throw new NotImplementedException();
		}


		static public Add Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Add>.Instance;
			}
		}

	}
}
