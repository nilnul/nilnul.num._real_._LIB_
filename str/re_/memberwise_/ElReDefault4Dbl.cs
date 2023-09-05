using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.re_.memberwise_
{
	public class ElReDefault4Dbl<TRe>
		: re_.Memberwise4dbl
		where TRe:
			nilnul.obj.ReI<double>
			,new()
	{
		public ElReDefault4Dbl() : base(

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TRe>.Instance

		)
		{
		}


		static public ElReDefault4Dbl<TRe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ElReDefault4Dbl<TRe>>.Instance;
			}
		}

	}
}
