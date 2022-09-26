using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.str.to_.scalar_
{
	public class Variance:
		ScalarI
	{
		public Algebraic to(
			IEnumerable<Algebraic> fracs
		) {
			return op_.binary_.add.cumulator.Cumulate.Singleton.cumulate(
				fracs.Select(f=>f*f)
			);

		}


		static public Variance Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Variance>.Instance;
			}
		}

	}
}
