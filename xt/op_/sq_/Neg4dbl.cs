using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.of_.unary_.sq_
{
	public class Neg4dbl
		:
		real.ext.of_.unary_.OfExt4dblA
	{
		public override double _op_0ext(double par)
		{
			return -(par*par);
			//throw new NotImplementedException();
		}


		static public Neg4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Neg4dbl>.Instance;
			}
		}

	}
}
