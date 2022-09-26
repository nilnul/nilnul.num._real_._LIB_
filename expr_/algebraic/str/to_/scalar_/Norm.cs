using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.frac.str.to_.scalar_
{
	/// <summary>
	/// sqrt is not a algebraic operation, nor a division.
	/// </summary>
	public class Norm:
		ScalarI
	{
		public algebraic.Frac to(
			IEnumerable<Frac> fracs
		) {
			return ;

		}


		static public Norm Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Norm>.Instance;
			}
		}

	}
}
