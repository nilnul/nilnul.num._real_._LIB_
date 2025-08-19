using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.of_.unary_
{
	public class Square4dbl
		:
		real.ext.of_.unary_.OfExt4dblA
	{
		public override double _op_0ext(double par)
		{
			
			/// inf * inf ;
			return par * par;
			//throw new NotImplementedException();
		}


		static public Square4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Square4dbl>.Instance;
			}
		}

	}
}
