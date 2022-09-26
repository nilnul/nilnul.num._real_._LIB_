using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed.re.complement_
{
	public class ReNeo4Dbl<TRe>
		:
		Complement4dbl
		where TRe : closed.Re4dblI, new()
	{
		public ReNeo4Dbl() : base(

				 nilnul._obj.typ_.nilable_.unprimable_.Singleton<TRe>.Instance

		)
		{
		}


		static public ReNeo4Dbl<TRe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ReNeo4Dbl<TRe>>.Instance;
			}
		}

	}
}
