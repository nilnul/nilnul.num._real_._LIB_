using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.co.be.vow_
{
	public class BeDefaulted<TBe>
		:
		ext.border.co.be.Vow4dbl
		where TBe : nilnul.obj.BeI_ofIn<(Border4dblI, Border4dblI)>, new()
	{
		public BeDefaulted() : base(
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
		)
		{
		}


		static public BeDefaulted<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefaulted<TBe>>.Instance;
			}
		}

	}
}
