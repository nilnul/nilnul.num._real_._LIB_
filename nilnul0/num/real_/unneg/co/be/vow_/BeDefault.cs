using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.nonneg.co.be.vow_
{
	public class BeDefault4Dbl<TBe>
		:
		be.Vow
		where TBe :
			nilnul.obj.BeI1<nonneg.CoDbl>,new()
	{
		public BeDefault4Dbl() : base(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
				)
		{
		}


		static public BeDefault4Dbl<TBe> Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<BeDefault4Dbl<TBe>>.Instance;
			}
		}
		static public BeDefault4Dbl<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefault4Dbl<TBe>>.Instance;
			}
		}



	}
}
