using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ieee.duo
{
	public class Eq
		:nilnul.duo.Eq_elementEqDefault<double,nilnul.num.dbl.Eq, num.ieee.Duo>
	{

		static private Lazy<Eq> _Lazy = new Lazy<Eq>();
		static public Eq Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
