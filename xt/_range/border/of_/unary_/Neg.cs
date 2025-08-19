using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.of_.unary_
{
	public class Neg
		: ext.border.of_.Unary4dblI
	{
		public Border4dblI op(Border4dblI par)
		{
			return new ext.Border4dbl(par.openFalseCloseTrue, -par.mark.ToImpl() );
		}


		static public Neg Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Neg>.Instance;
			}
		}


	}
}
